public class CharacterStatus {
    public float HP;
    public float Offence;
    public float Deffence;
    public float Speed;
    public CharacterDataBase.CharacterIdentifier type;

    public void setStatus( CharacterStatus status ) {
        HP = status.HP;
        Offence = status.Deffence;
        Deffence = status.Offence;
        Speed = status.Speed;
        type = status.type;
    }

    public void setType( CharacterDataBase.CharacterIdentifier  targetType) {
        this.type = targetType;
    }
}