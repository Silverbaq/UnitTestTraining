using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitTestTraining.Exercise4;
using Assert = NUnit.Framework.Assert;

namespace TestProject.Exercise4
{
    public class MyStackTests
    {
        [Test]
        public void TestPush()
        {
            // Arrange
            MyStack<int> stack = new MyStack<int>();

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Assert
            Assert.IsFalse(stack.IsEmpty());
            Assert.AreEqual(3, stack.Peek());
        }

        [Test]
        public void TestPop()
        {
            // Arrange
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act
            int poppedItem = stack.Pop();

            // Assert
            Assert.AreEqual(3, poppedItem);
            Assert.AreEqual(2, stack.Peek());
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPopEmpty()
        {
            // Arrange
            MyStack<int> stack = new MyStack<int>();

            // Act
            stack.Pop();

            // Exception expected
        }

        [Test]
        public void TestPeek()
        {
            // Arrange
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act
            int peekedItem = stack.Peek();

            // Assert
            Assert.AreEqual(3, peekedItem);
            Assert.AreEqual(3, stack.Peek());
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPeekEmpty()
        {
            // Arrange
            MyStack<int> stack = new MyStack<int>();

            // Act
            stack.Peek();

            // Exception expected
        }

        [Test]
        public void TestIsEmpty()
        {
            // Arrange
            MyStack<int> stack = new MyStack<int>();

            // Assert
            Assert.IsTrue(stack.IsEmpty());

            // Act
            stack.Push(1);

            // Assert
            Assert.IsFalse(stack.IsEmpty());

            // Act
            stack.Pop();

            // Assert
            Assert.IsTrue(stack.IsEmpty());
        }
    }
}