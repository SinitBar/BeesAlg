using NoStringEvaluating.Contract.Variables;
using System;

namespace BeesAlg
{
    public partial class Form1 : Form
    {
        Parameters parameters;
        const int maxVariablesAmount = 10;
        public Form1()
        {
            InitializeComponent();
        }

        void CorrectDoubleInputs()
        {
            // replace dots to semicolons in text strings if needed
            textBoxLowerLimitVariables.Text = textBoxLowerLimitVariables.Text.Replace('.', ',');
            textBoxUpperLimitVariables.Text = textBoxUpperLimitVariables.Text.Replace('.', ',');
            textBoxStopDelta.Text = textBoxStopDelta.Text.Replace('.', ',');
            textBoxSearchNeighborhood.Text = textBoxSearchNeighborhood.Text.Replace('.', ',');
        }

        void MessageUserWrongData(string message)
        {
            MessageBox.Show(message, "Wrong input data", MessageBoxButtons.OK);
        }

        string[] GetVariables()
        {
            List<string> variables = new List<string>();
            variables.Clear();
            string[] vars = textBoxVariables.Text.Split(" ", maxVariablesAmount + 1);
            for (int i = 0; i < Math.Min(vars.Length, maxVariablesAmount); i++)
                variables.Add(vars[i]);
            return variables.ToArray();
        }

        bool GetParametersOk()
        {
            CorrectDoubleInputs();

            double dResult = 0;
            int iResult = 0;

            int iterationsAmount = 0;
            double stopDelta = 0;

            if (checkBoxStopDelta.Checked)
                if (!double.TryParse(textBoxStopDelta.Text, out stopDelta))
                {
                    MessageUserWrongData("stop delta should be a double positive number");
                    return false;
                }

            if (stopDelta < 0)
            {
                MessageUserWrongData("stop delta should be a double positive number");
                return false;
            }

            if (checkBoxIterationsAmount.Checked)
                if (!int.TryParse(textBoxIterationsAmount.Text, out iterationsAmount))
                {
                    MessageUserWrongData("iterations amount should be an integer positive number");
                    return false;
                }

            if (iterationsAmount < 0)
            {
                MessageUserWrongData("iterations amount should be an integer positive number");
                return false;
            }

            if (!checkBoxIterationsAmount.Checked && !checkBoxStopDelta.Checked)
            {
                MessageUserWrongData("’от€ бы один критерий остановки должен быть выбран");
                return false;
            }

            if (double.TryParse(textBoxLowerLimitVariables.Text, out dResult))
            {
                if (double.TryParse(textBoxUpperLimitVariables.Text, out dResult))
                {
                    if (int.TryParse(textBoxResearchPointsAmount.Text, out iResult))
                    {
                        if (int.TryParse(textBoxBeesResearchPointsAmount.Text, out iResult))
                        {
                            if (iResult >= int.Parse(textBoxResearchPointsAmount.Text))
                            {
                                MessageUserWrongData(" оличество мест, исследуемых пчелами (m), должно быть меньше количества мест в целом (s)");
                                return false;
                            }

                            if (int.TryParse(textBoxElitePlacesAmount.Text, out iResult))
                            {
                                if (iResult >= (double)int.Parse(textBoxBeesResearchPointsAmount.Text) / 2d)
                                {
                                    MessageUserWrongData(" оличество элитных мест (e), должно быть меньше половины мест, исследуемых пчелами (m / 2)");
                                    return false;
                                }

                                if (int.TryParse(textBoxBeesAmountToResearchElitePlaces.Text, out iResult))
                                {
                                    if (int.TryParse(textBoxBeesAmountToResearchUsualPlaces.Text, out iResult))
                                    {
                                        if (double.TryParse(textBoxSearchNeighborhood.Text, out dResult))
                                        {
                                            parameters = new Parameters(
                                                double.Parse(textBoxLowerLimitVariables.Text),
                                                double.Parse(textBoxUpperLimitVariables.Text),
                                                textBoxFunction.Text,
                                                GetVariables(),
                                                int.Parse(textBoxResearchPointsAmount.Text),
                                                int.Parse(textBoxBeesResearchPointsAmount.Text),
                                                int.Parse(textBoxElitePlacesAmount.Text),
                                                int.Parse(textBoxBeesAmountToResearchElitePlaces.Text),
                                                int.Parse(textBoxBeesAmountToResearchUsualPlaces.Text),
                                                double.Parse(textBoxSearchNeighborhood.Text),
                                                iterationsAmount,
                                                stopDelta,
                                                checkBoxIterationsAmount.Checked,
                                                checkBoxStopDelta.Checked);
                                            return true;
                                        }
                                        else
                                            MessageUserWrongData("search neighborhood should be a double positive number");
                                    }
                                    else
                                        MessageUserWrongData("bees amount to research usual places should be an integer positive number");
                                }
                                else
                                    MessageUserWrongData("bees amount to research elite places should be an integer positive number");
                            }
                            else
                                MessageUserWrongData("elite places amount should be an integer positive number");
                        }
                        else
                            MessageUserWrongData("bees research places amount should be an integer positive number");
                    }
                    else
                        MessageUserWrongData("research places amount should be an integer positive number");
                }
                else
                    MessageUserWrongData("upper limit variable should be a double number");
            }
            else
                MessageUserWrongData("lower limit variable should be a double number");
            return false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (GetParametersOk())
            {
                textBoxOutput.Text = "";
                BeesAlgorithm beesAlgorithm = new BeesAlgorithm(parameters);
                double[] minimum = beesAlgorithm.Execute();
                for (int i = 0; i < minimum.Length; i++)
                    textBoxOutput.AppendText(parameters.Variables[i] + " = " + minimum[i] + 
                        Environment.NewLine);
            }
        }
    }
}