using Idaf.Dominio.Interfaces;

namespace Idaf.Dominio.Entidades
{
    public class User : IIdentityEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
