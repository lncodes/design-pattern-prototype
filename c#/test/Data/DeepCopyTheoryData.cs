using Xunit;

namespace Lncodes.Tutorial.Prototype.Test
{
    public sealed class DeepCopyTheoryData : TheoryData<string, int, DeepInventory>
    {
        public DeepCopyTheoryData()
        {
            Add("Mario", 100, new DeepInventory(10));
        }
    }
}
