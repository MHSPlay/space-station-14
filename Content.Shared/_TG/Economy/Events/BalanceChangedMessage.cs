using Robust.Shared.Player;

namespace Content.Shared._TG.Economy.Events;
public sealed class BalanceChangedEvent : EntityEventArgs
{
    public readonly int Amount;
    public readonly ICommonSession Player;

    public BalanceChangedEvent(int amount, ICommonSession player)
    {
        Amount = amount;
        Player = player;
    }
}
