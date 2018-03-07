using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using MathWizard.Controllers;
using MathWizard.Models;

namespace MathWizardTests
{
    public class MathWizardTests
    {

        private MathController controller = new MathController();

        [Fact]
        public void TestAddition()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 30;
            op.RightOperand = 29;
            op.Operator = "Plus";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(59, model.Result);

        }

                [Fact]
        public void TestSubtraction()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 40;
            op.RightOperand = 30;
            op.Operator = "Minus";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(10, model.Result);
        }

        [Fact]
        public void TestDivision()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 60;
            op.RightOperand = 25;
            op.Operator = "Divided By";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(2.4, Math.Round(model.Result, 1));

        }

        [Fact]
        public void TestMultiplication()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 3;
            op.RightOperand = 4;
            op.Operator = "Times";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(12, model.Result);
        }

                [Fact]
        public void TestModulus()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 85;
            op.RightOperand = 9;
            op.Operator = "Modulus";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(4, model.Result);
        }

                [Fact]
        public void TestRound()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 6.8F;
            op.RightOperand = 0;
            op.Operator = "Round";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(7, model.Result);
        }

                [Fact]
        public void TestFloor()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 6.7F;
            op.RightOperand = 0;
            op.Operator = "Floor";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(6, model.Result);
        }

                [Fact]
        public void TestCeiling()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 6.3F;
            op.RightOperand = 0;
            op.Operator = "Ceiling";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(7, model.Result);
        }

    }
}
