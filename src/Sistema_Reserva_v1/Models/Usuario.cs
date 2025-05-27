namespace WebApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }

        public int RolId { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        //public bool Activo { get; set; }
        // Constructor por defecto
        public Usuario()
        {
            Created_at = DateTime.Now;
            //Activo = true;
        }
    }
}
