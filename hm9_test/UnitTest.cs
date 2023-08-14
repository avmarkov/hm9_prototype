using hm9_prototype.Entities;

namespace hm9_test
{
    public class UnitTest
    {
        [Fact]
        public void CloneTest()
        {
            var prototypeThirdClass = new ThirdClass();
            var clonedThirdClass = (ThirdClass)prototypeThirdClass.Clone();
            Assert.Equal(prototypeThirdClass.ToString(), clonedThirdClass.ToString());
        }

        [Fact]
        public void MyCloneTest()
        {
            var prototypeThirdClass = new ThirdClass();
            var clonedThirdClass_my = prototypeThirdClass.MyClone();
            Assert.Equal(prototypeThirdClass.ToString(), clonedThirdClass_my.ToString());
        }
    }
}