namespace Intranet.Get
{
    public class SistemaView : BaseView
    {
        public SistemaView()
        {
            Sistemas = Sistemas.Where(x => x.Ativo).ToList();

        }

    }
}
