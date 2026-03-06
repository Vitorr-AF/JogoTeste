namespace JogoTeste.Utils
{
    public class UIHelper
    {
        public void Centralizar(Panel interno, Panel pai)
        {
            interno.Left = (pai.Width - interno.Width) / 2;
            interno.Top = (pai.Height - interno.Height) / 2;
        }

        public void DefinirTamanho(PictureBox pb, int tamanho)
        {
            pb.Left = pb.Left + (pb.Width - tamanho) / 2;
            pb.Top = pb.Top + (pb.Height - tamanho) / 2;

            pb.Width = tamanho;
            pb.Height = tamanho;
            // labelDebug.Visible = true
            // labelDebug.Text = $"Left: {pb.Left} Largura: {pb.Width}\nTop: {pb.Top} Altura: {pb.Height}";
        }
    }
}