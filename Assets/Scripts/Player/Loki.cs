public class Loki : Player
{
    public Loki()
    {
        _maxHealth = 3;
        _maxAmmo = 4;
        _ammo = 1;
        _playerType = PlayerType.B;
    }

    public override void GetDamage()
    {
        if (_actionType == PlayerActionType.Dodge)
        {
            ReloadAmmo();
            IsUltimateUsed = true;
        }
        else
        {
            GetDamage();
        }
    }
}
