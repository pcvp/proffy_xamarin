using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using System.Threading.Tasks;

namespace Proffy.Droid {

    [Activity(Theme = "@style/MainTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashScreenActivity : Activity {
        private static readonly string TAG = "Proffy:" + typeof(SplashScreenActivity).Name;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            Log.Debug(TAG, "SplashScreenActivity.OnCreate");
        }

        protected override void OnResume() {
            base.OnResume();

            Task atividadesDeInicializacao = new Task(() => {
                Log.Debug(TAG, "Inicializando app.");
                Intent intent = new Intent(Application.Context, typeof(MainActivity));

                if (Intent.Extras != null) {
                    intent.PutExtras(Intent);
                }

                base.StartActivity(intent);
            });
            atividadesDeInicializacao.Start();
        }

        public override void OnBackPressed() {
        }

        protected override void OnNewIntent(Intent intent) {
            base.OnNewIntent(intent);
        }
    }
}