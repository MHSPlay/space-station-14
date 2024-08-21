using Content.Server.GameTicking;
using Content.Server.Preferences.Managers;
using Robust.Server.Player;
using Content.Shared._TG.Economy;
using Content.Shared.Players;
using Robust.Shared.GameStates;

namespace Content.Server._TG.Economy;


public class EconomySystem : EntitySystem
{
    [Dependency] private readonly IPlayerManager _playerManager = default!;
    [Dependency] private readonly IServerPreferencesManager _prefsManager = default!;
    private ISawmill _log = default!;

    public override void Initialize()
    {
        base.Initialize();
        _log = Logger.GetSawmill("economic");
        SubscribeLocalEvent<BankComponent, ComponentGetState>(OnBankChanged);
    }

    public void OnBankChanged(EntityUid uid, BankComponent component, ref ComponentGetState args)
    {
        var user = args.Player?.UserId;
        Console.WriteLine($"Bank changed! User balance: {component.Balance}");
        Console.WriteLine($"ID account changed! User accountID: {component.AccountId}");
    }
}
