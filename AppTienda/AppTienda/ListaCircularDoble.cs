using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda
{
    public class Nodo<T> 
    {
        public T Data { get; set; }
        public Nodo<T> Next { get; set; }
        public Nodo<T> Prev { get; set; }
    }

    public class ListaCircularDoble<T>
    {
        private Nodo<T> cabeza;
        private Nodo<T> cola;

        public void Agregar(T data)
        {
            Nodo<T> nuevoNodo = new Nodo<T> { Data = data };

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
                cabeza.Next = cabeza;
                cabeza.Prev = cabeza;
            }
            else
            {
                Nodo<T> elemento = cabeza;
                if (ObtenerId(data) < ObtenerId(cabeza.Data))
                {
                    nuevoNodo.Next = cabeza;
                    nuevoNodo.Prev = cola;
                    cabeza.Prev = nuevoNodo;
                    cola.Next = nuevoNodo;
                    cabeza = nuevoNodo;
                }
                else
                {
                    do
                    {
                        if (elemento.Next == cabeza || ObtenerId(data) < ObtenerId(elemento.Next.Data))
                        {
                            nuevoNodo.Next = elemento.Next;
                            nuevoNodo.Prev = elemento;
                            if (elemento.Next != null)
                            {
                                elemento.Next.Prev = nuevoNodo;
                            }
                            elemento.Next = nuevoNodo;
                            if (nuevoNodo.Next == cabeza)
                            {
                                cola = nuevoNodo;
                            }
                            break;
                        }
                        elemento = elemento.Next;
                    } while (elemento != cabeza);
                }
            }
        }

        public void Eliminar(int numeroVenta)
        {
            if (cabeza == null) return; 

            Nodo<T> actual = cabeza;
            if (cabeza == cabeza.Next)
            {
                if (((Venta)(object)actual.Data).NumeroVenta == numeroVenta)
                {
                    cabeza = null;
                    cola = null;
                }
                return;
            }
            do
            {
                if (((Venta)(object)actual.Data).NumeroVenta == numeroVenta)
                {
                    if (actual == cabeza)
                    {
                        cabeza = cabeza.Next;
                        cabeza.Prev = cola;
                        cola.Next = cabeza;
                    }
                    else if (actual == cola)
                    {
                        cola = cola.Prev;
                        cola.Next = cabeza;
                        cabeza.Prev = cola;
                    }
                    else
                    {
                        actual.Prev.Next = actual.Next;
                        actual.Next.Prev = actual.Prev;
                    }
                    return;
                }
                actual = actual.Next;
            } while (actual != cabeza); 
        }

        private int ObtenerId(T obj)
        {
            var propiedad = obj.GetType().GetProperty("NumeroVenta");
            if (propiedad != null)
            {
                return (int)propiedad.GetValue(obj);
            }
            return 0;
        }


        public List<T> ObtenerVentas()
        {
            List<T> ventas = new List<T>();
            if (cabeza == null) return ventas;

            Nodo<T> actual = cabeza;
            do
            {
                ventas.Add(actual.Data);
                actual = actual.Next;
            } while (actual != cabeza);

            return ventas;
        }

    }



}
