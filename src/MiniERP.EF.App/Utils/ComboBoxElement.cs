namespace MiniERP.EF.App.Utils
{
    internal class ComboBoxElement
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
