using Backprop;

namespace back_propagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        int[][] truthTable =
        [
            [0, 0, 0, 0, 0],
            [0, 0, 0, 1, 0],
            [0, 0, 1, 0, 0],
            [0, 0, 1, 1, 0],
            [0, 1, 0, 0, 0],
            [0, 1, 0, 1, 0],
            [0, 1, 1, 0, 0],
            [0, 1, 1, 1, 0],
            [1, 0, 0, 0, 0],
            [1, 0, 0, 1, 0],
            [1, 0, 1, 0, 0],
            [1, 0, 1, 1, 0],
            [1, 1, 0, 0, 0],
            [1, 1, 0, 1, 0],
            [1, 1, 1, 0, 0],
            [1, 1, 1, 1, 1],
        ];

        public Form1()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 1000, 1);
            MessageBox.Show(nn.getNumbers());
        }

        private void trainBtn_Click(object sender, EventArgs e)
        {
            for (int epoch = 0; epoch < 100; epoch++)
            {
                foreach (var row in truthTable)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        nn.setInputs(i, (double)row[i]);
                    }
                    nn.setDesiredOutput(0, (double)row[4]);
                    nn.learn();
                }
            }
            MessageBox.Show("Training Completed!");
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(inputA.Text));
            nn.setInputs(1, Convert.ToDouble(inputB.Text));
            nn.setInputs(2, Convert.ToDouble(inputC.Text));
            nn.setInputs(3, Convert.ToDouble(inputD.Text));

            nn.run();
            outputA.Text = "" + nn.getOuputData(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
