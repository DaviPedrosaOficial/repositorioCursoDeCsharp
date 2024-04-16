/* ------ Classe criada para auxiliar a aula 1 ------ */

using CursoDeCsharp.Cap6.Aulas.Entities.Enums;

namespace CursoDeCsharp.Cap6.Aulas.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}