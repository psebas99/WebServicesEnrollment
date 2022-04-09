using WebServicesEnrollment.Models;

namespace WebServicesEnrollment.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private List<Aspirante> aspirantes = new List<Aspirante> ();
        private List<CarreraTecnica> carreras = new List<CarreraTecnica> ();
        private List<Cargo> cargos = new List<Cargo> ();
        public EnrollmentService()
        {
            aspirantes.Add(new Aspirante() {NoExpediente = "EXP-2022001", Apellidos = "Perez", Nombres= "Luis", Email = "lperez@gmail.com",Direccion = "Guatemala", Telefono = " 123"});
            aspirantes.Add(new Aspirante() {NoExpediente = "EXP-2022002", Apellidos = "Mancila", Nombres= "Raul", Email = "rmancilla@gmail.com",Direccion = "Guatemala", Telefono = " 456"});
            aspirantes.Add(new Aspirante() {NoExpediente = "EXP-2022003", Apellidos = "Lemus", Nombres= "Roberto", Email = "rlemus@gmail.com",Direccion = "Guatemala", Telefono = " 789"});
            carreras.Add(new CarreraTecnica() {CarreraId = "1", Carrera = "Full Stack DOTNET Core"});
            carreras.Add(new CarreraTecnica() {CarreraId = "2", Carrera = "Full Stack Java EE"});
            carreras.Add(new CarreraTecnica() {CarreraId = "3", Carrera = "desarrollo movil con Andriod"});
            cargos.Add(new Cargo() {CargoId = "1" ,Descripcion = "Pago por inscripcion", Prefijo = "INSC" , Monto = 1200.00, IsGeneraMora = false, PorcentajeMora = 0});
            cargos.Add(new Cargo() {CargoId = "2" ,Descripcion = "Pago por carne", Prefijo = "CARNE" , Monto = 30.00, IsGeneraMora = false, PorcentajeMora = 0});
            cargos.Add(new Cargo() {CargoId = "3" ,Descripcion = "Pago academico mensual", Prefijo = "PAGM" , Monto = 800.00, IsGeneraMora = false, PorcentajeMora = 0});
        }


        public EnrollmentResponse EnrollmentProcess(EnrollmentRequest request)
        {
            EnrollmentResponse respuesta = null;
            
            if(buscarAspirante(request.NoExpediente) == null)
            {
                respuesta = new EnrollmentResponse(){Codigo = 204, Respuesta = "No existen registros"};
            }
            else
            {
                respuesta = new EnrollmentResponse(){Codigo = 201 , Respuesta = "Enrollment sucess!!!"};
            }

            return respuesta;
        }

        public Aspirante buscarAspirante(string noExpediente)
        {
        Aspirante resultado = null;
        for(int i = 0; i < aspirantes.Count; i++ )
        {
            if(aspirantes[i].NoExpediente == noExpediente)
            {
                resultado = aspirantes[i];
                break;
            }
        }
         return resultado;
        }


        public string Test(string s)
        {
            Console.WriteLine("Test method executed");
            return s;
        }
    }
}