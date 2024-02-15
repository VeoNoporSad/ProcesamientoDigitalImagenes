using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DigitalImagen
{
    internal class Program
    {
        static List<Usuario> listaCliente = new List<Usuario>();

        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Aquí tiene sus actuales usuarios:");
                foreach (Usuario usuario in listaCliente)
                {
                    Console.WriteLine($"ID: {usuario.id}");
                    Console.WriteLine($"Nombre: {usuario.Nombre}");
                    Console.WriteLine($"Contraseña: {usuario.Contraseña}");
                    Console.WriteLine();
                }

                Console.WriteLine("Si desea agregar un usuario, presione 1");
                Console.WriteLine("Si desea eliminar un usuario, presione 2");
                Console.WriteLine("Si desea editar un usuario, presione 3");
                Console.WriteLine("Para salir, presione cualquier otra tecla");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Ingrese el ID del nuevo usuario:");
                        int idNuevo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Nombre del nuevo usuario:");
                        string nombreNuevo = Console.ReadLine();
                        Console.WriteLine("Ingrese la Contraseña del nuevo usuario:");
                        string contraseñaNueva = Console.ReadLine();

                        Usuario nuevoUsuario = new Usuario()
                        {
                            id = idNuevo,
                            Nombre = nombreNuevo,
                            Contraseña = contraseñaNueva
                        };

                        listaCliente.Add(nuevoUsuario);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Ingrese el ID del usuario a eliminar:");
                        int idBorrado = int.Parse(Console.ReadLine());
                        listaCliente.RemoveAll(usuario => usuario.id == idBorrado);
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Ingrese el ID del usuario a editar:");
                        int idEditar = int.Parse(Console.ReadLine());

                        Usuario usuarioEditar = listaCliente.Find(usuario => usuario.id == idEditar);
                        if (usuarioEditar != null)
                        {
                            Console.WriteLine("Ingrese el nuevo nombre del usuario:");
                            usuarioEditar.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la nueva contraseña del usuario:");
                            usuarioEditar.Contraseña = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Usuario no encontrado.");
                        }
                        break;

                    default:
                        continuar = false;
                        break;
                }
            }
        }
    }

    public class Usuario
    {
        public int id;
        public string Nombre;
        public string Contraseña;
    }
}
