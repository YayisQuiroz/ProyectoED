using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace AppTienda
{
    public partial class FrmAdministrador : Form
    {

        private ListaCircularDoble<Venta> listaVenta;
        Usuario usario = new Usuario();
        private bool ventasCargadas = false;

        public FrmAdministrador()
        {
            InitializeComponent();
            listaVenta = new ListaCircularDoble<Venta>();
            Form1 log = new Form1();
            log.ShowDialog();
            usario = log.User;
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {

            if (usario.Administrador == true)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnMostrar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnMostrar.Enabled = false;
            }
        }
        private void btmAgregar_Click(object sender, EventArgs e)
        {
            if (listaVenta == null)
            {
                listaVenta = new ListaCircularDoble<Venta>();
            }
            int numeroVenta = (int)nudNumeroVenta.Value;
            string producto = txtProducto.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            decimal total = decimal.Parse(txtTotal.Text);
            DateTime fecha = dtpFecha.Value;

            Venta nuevaVenta = new Venta
            {
                NumeroVenta = numeroVenta,
                Fecha = fecha,
                Producto = producto,
                Cantidad = cantidad,
                Total = total,
            };
            listaVenta.Agregar(nuevaVenta);
            ActualizarListView(listaVenta.ObtenerVentas());
            GuardarVentasEnArchivo();
            Inicializarcontroles();
        }
        public void ActualizarListView(List<Venta> ventas)
        {
            LvVentas.Items.Clear();
            foreach (var venta in ventas)
            {
                var fila = new ListViewItem(venta.NumeroVenta.ToString());
                fila.SubItems.Add(venta.Fecha.ToString("dd/MM/yyyy"));
                fila.SubItems.Add(venta.Producto);
                fila.SubItems.Add(venta.Cantidad.ToString());
                fila.SubItems.Add(venta.Total.ToString());
                LvVentas.Items.Add(fila);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (LvVentas.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = LvVentas.SelectedItems[0];
                int numeroVenta = int.Parse(itemSeleccionado.SubItems[0].Text);
                Venta ventaSeleccionada = listaVenta.ObtenerVentas().FirstOrDefault(v => v.NumeroVenta == numeroVenta);

                if (ventaSeleccionada != null)
                {
                    listaVenta.Eliminar(numeroVenta);
                    ventaSeleccionada.NumeroVenta = (int)nudNumeroVenta.Value;
                    ventaSeleccionada.Producto = txtProducto.Text;
                    ventaSeleccionada.Cantidad = int.Parse(txtCantidad.Text); 
                    ventaSeleccionada.Total = decimal.Parse(txtTotal.Text); 
                    ventaSeleccionada.Fecha = dtpFecha.Value;
                    listaVenta.Agregar(ventaSeleccionada);
                    GuardarVentasEnArchivo();
                    ActualizarListView(listaVenta.ObtenerVentas());
                    MessageBox.Show("Venta modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Inicializarcontroles();
                }
                else
                {
                    MessageBox.Show("No se encontró la venta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una venta para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvVentas.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = LvVentas.SelectedItems[0];

                nudNumeroVenta.Value = int.Parse(itemSeleccionado.SubItems[0].Text);
                txtProducto.Text = itemSeleccionado.SubItems[2].Text;
                txtCantidad.Text = itemSeleccionado.SubItems[3].Text;
                txtTotal.Text = itemSeleccionado.SubItems[4].Text.ToString();
                dtpFecha.Value = DateTime.Parse(itemSeleccionado.SubItems[1].Text);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (LvVentas.SelectedItems.Count > 0)
            {
                var elementoSeleccionado = LvVentas.SelectedItems[0];
                int numeroVenta;
                if (int.TryParse(elementoSeleccionado.SubItems[0].Text, out numeroVenta))
                {
                    listaVenta.Eliminar(numeroVenta);
                    GuardarVentasEnArchivo();
                    ActualizarListView(listaVenta.ObtenerVentas());
                }
                else
                {
                    MessageBox.Show("El número de venta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un elemento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void GuardarVentasEnArchivo()
        {
            try
            {
                var ventasJson = Newtonsoft.Json.JsonConvert.SerializeObject(listaVenta.ObtenerVentas(), Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText("ventas.json", ventasJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar las ventas en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        public void CargarVentasDesdeArchivo()
        {
            string path = "ventas.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<Venta> ventas = JsonConvert.DeserializeObject<List<Venta>>(json);
                foreach (var venta in ventas)
                {
                    listaVenta.Agregar(venta);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron ventas registradas.");
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var ventasFiltradas = listaVenta.ObtenerVentas();
            if (chkFechaAscendente.Checked)
            {
                ventasFiltradas = ventasFiltradas.OrderBy(v => v.Fecha).ToList();
            }
            else if (chkFechaDescendente.Checked)
            {
                ventasFiltradas = ventasFiltradas.OrderByDescending(v => v.Fecha).ToList();
            }
            else if (chkNombre.Checked)
            {
                ventasFiltradas = ventasFiltradas.OrderBy(v => v.Producto.ToLower()).ToList();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un criterio de ordenamiento.", "Criterio requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ActualizarListView(ventasFiltradas);
        }
        private void chkFechaAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFechaAscendente.Checked)
            {
                chkFechaDescendente.Checked = false;
                chkNombre.Checked = false;
            }
        }
        private void chkFechaDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFechaDescendente.Checked)
            {
                chkFechaAscendente.Checked = false;
                chkNombre.Checked = false;
            }
        }
        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNombre.Checked)
            {
                chkFechaAscendente.Checked = false;
                chkFechaDescendente.Checked = false;
            }
        }
        public void Inicializarcontroles()
        {
            nudNumeroVenta.Value = nudNumeroVenta.Minimum;
            txtProducto.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (ventasCargadas)
            {
                return;
            }
            LvVentas.Items.Clear();
            CargarVentasDesdeArchivo();
            ActualizarListView(listaVenta.ObtenerVentas());
            ventasCargadas = true;
        }
        private void TextBox_SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}