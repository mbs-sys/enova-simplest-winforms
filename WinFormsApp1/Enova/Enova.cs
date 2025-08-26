using Soneta.Business;
using Soneta.Business.App;
using Soneta.Handel;
using Soneta.Tools;

namespace Enova
{
    public class Enova : IDisposable
    {
        private IDisposable _SessionStateDisposable;
        private Login _Login;

        public Enova()
        {
            Database db = BusApplication.Instance["MBStestnet"];
            _SessionStateDisposable = SessionState.Create().Attach();
            _Login = db.Login(false, "Administrator", "");
        }

        public static void LoadLibsFirst()
        {
            Soneta.Start.Loader loader = new Soneta.Start.Loader() { WithUI = true, WithNet = false };
            loader.Load();
        }

        public void Dispose()
        {
            _Login?.Database?.Dispose();
            _Login?.Dispose();
            _SessionStateDisposable?.Dispose();
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
