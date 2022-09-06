namespace abstract_ornek
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }

        public virtual Marka HangiMarkanınAraci();
    }
}