using System;
using System.Collections.Generic;
using System.Linq;
using System.Activities;
using System.Text;
using System.ComponentModel;


namespace TestActivities
{
    public class CustomActivity : CodeActivity
    {
        [Category("Input")]
        public InArgument<double> FirstNumber { get; set; }

        [Category("Input")]
        public InArgument<double> SecondNumber { get; set; }

        [Category("Output")]
        public OutArgument<double> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var firstNumber = FirstNumber.Get(context);
            var secondNumber = SecondNumber.Get(context);
            var result = secondNumber + firstNumber;
            Result.Set(context, result);
        }
    }
}
