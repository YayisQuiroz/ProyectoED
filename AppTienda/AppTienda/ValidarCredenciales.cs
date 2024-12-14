using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTienda
{
    internal class ValidarCredenciales
    {
        private readonly string rutaArchivoUsuarios = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AppTienda", "Usuarios.json");
        public ValidarCredenciales()
        {
            if (!File.Exists(rutaArchivoUsuarios))
            {
                InicializarArchivoUsuarios();
            }
        }

        public bool ValidarUsuario(string nombre, string contraseña, out Usuario usuarioValidado)
        {
            usuarioValidado = null;

            try
            {
                if (!File.Exists(rutaArchivoUsuarios))
                    throw new FileNotFoundException("El archivo de usuarios no existe.");

                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(File.ReadAllText(rutaArchivoUsuarios));
                if (usuarios == null || usuarios.Count == 0)
                    throw new InvalidOperationException("No hay usuarios registrados.");

                var usuario = usuarios.FirstOrDefault(u => u.Nombre == nombre);
                if (usuario == null)
                    throw new UnauthorizedAccessException("Usuario no encontrado.");

                string contraseñaCifrada = CifrarSHA256(contraseña);

                if (!usuario.Contraseña.Equals(contraseñaCifrada))
                    throw new UnauthorizedAccessException("Contraseña incorrecta.");

                usuarioValidado = usuario;
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static string CifrarSHA256(string contrasena)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contrasena));

                StringBuilder builder = new StringBuilder();
                foreach (byte t in bytes)
                {
                    builder.Append(t.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void InicializarArchivoUsuarios()
        {
            var usuariosPorDefecto = new List<Usuario>
            {
                new Usuario { Nombre = "admin", Contraseña = CifrarSHA256("admin123"), Administrador = true },
                new Usuario { Nombre = "cajero1", Contraseña = CifrarSHA256("cajero123"), Administrador = false },
                new Usuario { Nombre = "cajero2", Contraseña = CifrarSHA256("cajero123"), Administrador = false }
            };

            string json = JsonConvert.SerializeObject(usuariosPorDefecto, Formatting.Indented);
            try
            {
                var directory = Path.GetDirectoryName(rutaArchivoUsuarios);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.WriteAllText(rutaArchivoUsuarios, json);

                MessageBox.Show("El archivo de usuarios se ha creado correctamente con usuarios por defecto.",
                                "Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el archivo de usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
