using Soneta.Business;
using Soneta.Business.App;
using Soneta.Handel;

namespace Enova
{
    public class Enova : IDisposable
    {
        private Login _Login;
        public Enova()
        {
            Database db = BusApplication.Instance["MBStestnet"];
            _Login = db.Login(false, "Administrator", "");
        }

        public static void LoadLibsFirst()
        {
            Soneta.Start.Loader loader = new Soneta.Start.Loader() { WithUI = true };
            loader.Load();
        }

        public void Dispose()
        {
            _Login.Dispose();
        }

        public IEnumerable<string> GetDokHandloweNumery()
        {
            using (Session session = _Login.CreateSession(false, false))
            {
                HandelModule hm = HandelModule.GetInstance(session);
                foreach (var d in hm.DokHandlowe.NumerWgNumeruDokumentu)
                {
                    yield return d.Numer.Pelny;
                }
            }
        }
    }
}
