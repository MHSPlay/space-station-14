using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared._TG.Economy;

[RegisterComponent, NetworkedComponent]
public sealed partial class BankComponent : Component
{
    [DataField("balance")]
    public int Balance;

    [DataField("accountid")]
    public int AccountId;
}
