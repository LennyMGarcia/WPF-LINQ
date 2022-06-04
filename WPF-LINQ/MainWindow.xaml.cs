using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace WPF_LINQ
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Datacontex que es como una especie de proxy con la base de datos, buscara una representacion ORM, un mapeo en la base de datos, como se relacionan etc
        DataClasses1DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["WPF_LINQ.Properties.Settings.CrudLinqSql"].ConnectionString;
            //mapeo de datos que vamos a conectar
            //mhace el mapeo orm
            dataContext = new DataClasses1DataContext(miConexion);

            //InsertaEmpresas();

            // InsertaEmpleados();

            //InsertaCargos();

            //InsertaEmpleadoCargo();

            //actualizaEmpleado();

            DeleteEmpleado();
        }

        public void InsertaEmpresas()
        {//Ejecuta un comando sql
           //dataContext.ExecuteCommand("DELETE FROM empresa");
            //en el dataclasses.dbml se encuentra este tipo de clases, esta en el modelo de datos
            //ese es el nombre del objeto no de la empresa
            empresa pildorasInformaticas = new empresa();

            pildorasInformaticas.nombre = "Pildoras Informaticas";
            //se pasa la instancia con el valor atribuido a la propiedad y luego se mapea
            dataContext.empresa.InsertOnSubmit(pildorasInformaticas);

            empresa EmpresaGoogle= new empresa();

            EmpresaGoogle.nombre = "Google";
            //se pasa la instancia con el valor atribuido a la propiedad y luego se mapea
            dataContext.empresa.InsertOnSubmit(EmpresaGoogle);

            empresa EmpresaCocacola= new empresa();

            EmpresaCocacola.nombre = "Coca cola";
            //se pasa la instancia con el valor atribuido a la propiedad y luego se mapea
            dataContext.empresa.InsertOnSubmit(EmpresaCocacola);
            //Actualiza cambios
            dataContext.SubmitChanges();
            //SOlo muestra el registro
            //llama al datagrid
            Principal.ItemsSource = dataContext.empresa;
        }

        public void InsertaEmpleados()
        {
            //se crea un objeto para buscar una empresa cuyo nombre sea pildoras informaticas, se usa first para elegir el nombre de la empresa 
            //se usa la expresion lambda para simplificarlo y el equials para ver si los objetos tienen el mismo valor, el em dicta automaticamente que es un pequeno objeto de tipo empresa
            empresa pildorasInformaticas = dataContext.empresa.First(em => em.nombre.Equals("Pildoras informaticas"));

            empresa empresaGoogle = dataContext.empresa.First(em => em.nombre.Equals("Google"));

            empresa empresaCocacola = dataContext.empresa.First(em => em.nombre.Equals("Coca cola"));

            List<empleado> Listaempleados = new List<empleado>();
            //se unserta todos los datos a traves de la lista creando un nuevo objeto luego se especifica que el id de la empresa es el id del objeto de la empresa creada cuyo nombre es pildoras informaticas
            Listaempleados.Add(new empleado { nombre = "juan", apellido = "Diaz", empresaID = pildorasInformaticas.Id });

            Listaempleados.Add(new empleado { nombre = "Ana", apellido = "Martin", empresaID = empresaGoogle.Id });

            Listaempleados.Add(new empleado { nombre = "Antonio", apellido = "Fernandez", empresaID = pildorasInformaticas.Id });

            Listaempleados.Add(new empleado { nombre = "Carlos", apellido = "Yael", empresaID = empresaGoogle.Id });

            //llama al data context con referencia a los empleados para agregar todos los elementos de la lista
            dataContext.empleado.InsertAllOnSubmit(Listaempleados);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.empleado;
        }

        public void InsertaCargos()
        {
            dataContext.cargo.InsertOnSubmit(new cargo { nombreCargi = "Director(a)" });
            
            dataContext.cargo.InsertOnSubmit(new cargo { nombreCargi = "Administrador(a)" });

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.cargo;
        }

        public void InsertaEmpleadoCargo()
        {
            //al parecer busca el id cuyo nombre sea Juan
          //  empleado Juan = dataContext.empleado.First(emp => emp.nombre.Equals("Juan"));

            empleado Ana = dataContext.empleado.First(emp => emp.nombre.Equals("Ana"));

            empleado Antonio = dataContext.empleado.First(emp => emp.nombre.Equals("Antonio"));

          

            cargo cDirector = dataContext.cargo.First(cg => cg.nombreCargi.Equals("Director(a)"));

            cargo cAdmin = dataContext.cargo.First(ca => ca.nombreCargi.Equals("Administrador(a)"));

            /*cargoempleado CargoJuan = new cargoempleado();
            //CargoJuan en su variable de empleado pone que sea igual al empleado
            CargoJuan.empleado = Juan;

            CargoJuan.cargoID = cDirector.Id;*/

            List<cargoempleado> ListaCargoEmpleado = new List<cargoempleado>();

            ListaCargoEmpleado.Add(new cargoempleado { empleado = Ana, cargo = cAdmin });

            ListaCargoEmpleado.Add(new cargoempleado { empleado = Antonio, cargo = cAdmin });

            

            dataContext.SubmitChanges();
            //origen de datos
            Principal.ItemsSource = dataContext.cargoempleado;




        }
        //se recomienda crear los metodo y todo eso en ingles
        public void actualizaEmpleado()
        {

            empleado Ana = dataContext.empleado.First(emp => emp.nombre.Equals("Ana Angeles"));

            Ana.nombre = "Ana Angelesss";

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.empleado;



        }
        public void DeleteEmpleado()
        {
            empleado Juan = dataContext.empleado.First(emp => emp.nombre.Equals("Juan"));
            //Objeto que me quiero cargar es juan
            dataContext.empleado.DeleteOnSubmit(Juan);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.empleado;
        }
    }
}
