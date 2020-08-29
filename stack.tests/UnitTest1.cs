using System;
using Xunit;
using FluentAssertions;

namespace stack.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData("there is no spoon")]
        public void Stack_Push_Stores_object(object obj)
        {
            var stack = new Stack();

            stack.Push(obj);
            var result = stack.Pop();

            result.Should().Be(obj);
        }

        [Fact]
        public void Stack_push_throws_exception_if_null_is_passed()
        {
            var stack = new Stack();
            stack.Push(1);

            stack.Invoking(x => x.Push(null)).Should().Throw<NullReferenceException>().WithMessage("Object cannot be null");
        }

        [Fact]
        public void Stack_Push_Stores_objects_pop_returns_them_in_LIFO_order()
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push("mosh");
            stack.Push(DateTime.Today);
            var result1 = stack.Pop();
            var result2 = stack.Pop();
            var result3 = stack.Pop();

            result1.Should().Be(DateTime.Today);
            result2.Should().Be("mosh");
            result3.Should().Be(1);

        }

        [Fact]
        public void Stack_Pop_called_on_empty_stack_throws_exception()
        {
            var stack = new Stack();

            stack.Invoking(x => x.Pop()).Should().Throw<InvalidOperationException>().WithMessage("You cannot pop object from an empty stack.");
        }

        [Fact]
        public void Stack_clear_clears_the_stack()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);

            stack.Clear();

            stack.Invoking(x => x.Pop()).Should().Throw<InvalidOperationException>().WithMessage("You cannot pop object from an empty stack.");
        }
    }
}
