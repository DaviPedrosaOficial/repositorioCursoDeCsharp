/* ------ Enumeração referente a classe Order, Aula 1 ------ */

namespace CursoDeCsharp.Cap6.Aulas.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}