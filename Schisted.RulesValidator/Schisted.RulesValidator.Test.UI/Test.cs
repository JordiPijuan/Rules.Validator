namespace Schisted.RulesValidator.Test.UI
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Core.Entities;
    using Core.Validators;

    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var validator = new TestObjectRulesValidator();
            validator.Validate(new TestObject());
            var textResult = new StringBuilder();

            textResult
                .AppendLine(
                    string.Format(
                        "The TestObject is valid: {0}", 
                        !validator.ResultCollection.Any(result => !result.Valid)
                        )
                    )
                .AppendLine();

            validator
                .ResultCollection
                .ToList()
                .ForEach(result => 
                    textResult.AppendLine(
                        string.Format(
                                "The rule {0} is valid: {1}",
                                result.Message,
                                result.Valid
                            )
                        )
                    );

            txtResult.Text = textResult.ToString();
        }

    }

}
