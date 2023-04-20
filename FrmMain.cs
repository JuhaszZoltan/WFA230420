using WFA230420.Properties;

namespace WFA230420
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void OnBtnRogzitClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJegyzet.Text))
            {
                MessageBox.Show(
                    caption: "HIBA!",
                    text: "Nem írtál be a névhez semmit...",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                lsbJegyzetek.Items.Add(txtJegyzet.Text);
                txtJegyzet.Clear();
            }
        }

        private void OnFrmMainLoad(object sender, EventArgs e)
        {
            using StreamReader sr = new($"{Resources.SaveFolder}prg.log");
            while (!sr.EndOfStream)
            {
                lsbJegyzetek.Items.Add(sr.ReadLine()!);
            }
        }

        private void OnFrmMainFormClosing(object sender, FormClosingEventArgs e)
        {
            using StreamWriter sw = new($"{Resources.SaveFolder}prg.log");
            foreach (string nev in lsbJegyzetek.Items)
            {
                sw.WriteLine(nev);
            }
        }

        private void OnBtnTorolClick(object sender, EventArgs e)
        {
            lsbJegyzetek.Items.Remove(lsbJegyzetek.SelectedItem);
        }

        private void OnTxtJegyzetKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                OnBtnRogzitClick(sender, e);
            }
        }
    }
}