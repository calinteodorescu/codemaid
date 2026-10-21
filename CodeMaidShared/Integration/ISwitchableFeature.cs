using System.Threading.Tasks;

namespace CalinTeodorescu.CodeMaid.Integration
{
    internal interface ISwitchableFeature
    {
        Task SwitchAsync(bool on);
    }
}