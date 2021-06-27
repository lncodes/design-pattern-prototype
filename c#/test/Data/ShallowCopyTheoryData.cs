using Xunit;

namespace Lncodes.Tutorial.Prototype.Test
{
    public sealed class ShallowCopyTheoryData : TheoryData<string, int, ShallowInventory>
    {
        public ShallowCopyTheoryData()
        {
            Add("Mario", 100, new ShallowInventory(10));
        }
    }
}
