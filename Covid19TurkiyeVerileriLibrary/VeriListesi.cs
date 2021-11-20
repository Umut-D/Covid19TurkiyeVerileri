namespace Covid19TurkiyeVerileriLibrary
{
    public abstract class VeriListesi
    {
        public Indir Indir { get; }

        protected VeriListesi(Indir indir)
        {
            Indir = indir;
        }
    }
}