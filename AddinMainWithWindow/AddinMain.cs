using EA;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AddinMainWithWindow
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("984881CA-2DBB-4CE5-BB90-ABDA59A9599D")]
    public class AddinMain : IComClassInterface
    {

        /// <summary>
        /// アドイン名
        /// </summary>
        string AddinName = "EASampleWithWindow";

        /// <summary>
        /// アドインの画面
        /// </summary>
        SampleWindow myWindow = null;

        /// <summary>
        /// EAコネクトイベント
        /// </summary>
        /// <param name="Repository">EAリポジトリ</param>
        /// <returns>アドインの種類</returns>
        public string EA_OnPostInitialized(EA.Repository Repository)
        {
            if (Repository.LibraryVersion < 1300)
            {

                MessageBox.Show("このアドインの動作には、ビルド1300以降が必要です。");
            }
            else
            {

                myWindow = (SampleWindow)Repository.AddWindow(AddinName, typeof(SampleWindow).FullName);
            }

            return string.Empty;
        }

        /// <summary>
        /// メニューアイテムうの取得
        /// </summary>
        /// <param name="Repository">EAリポジトリ</param>
        /// <param name="MenuLocation">メニューが呼ばれた位置</param>
        /// <param name="MenuName">親メニューの項目名</param>
        /// <returns>メニューの項目名</returns>
        public object EA_GetMenuItems(Repository Repository, string MenuLocation, string MenuName)
        {
            if (MenuName == "")
            {
                return "-&EASampleWithWindow";
            }
            else
            {
                String[] ret = { "&Sample" };
                return ret;
            }
        }

        /// <summary>
        /// メニュー項目のステータス取得
        /// </summary>
        /// <param name="Repository">EAリポジトリ</param>
        /// <param name="MenuLocation">メニューが呼ばれた位置</param>
        /// <param name="MenuName">親メニューの項目名</param>
        /// <param name="ItemName">メニューの項目名</param>
        /// <param name="IsEnabled">選択可否</param>
        /// <param name="IsChecked">チェック表示</param>
        public void EA_GetMenuState(Repository Repository, string MenuLocation, string MenuName, string ItemName, ref bool IsEnabled, ref bool IsChecked)
        {
            // 何もしない
        }

        /// <summary>
        /// メニュー項目のクリックイベント
        /// </summary>
        /// <param name="Repository">EAリポジトリ</param>
        /// <param name="MenuLocation">メニューが呼ばれた位置</param>
        /// <param name="MenuName">親メニューの項目名</param>
        /// <param name="ItemName">メニューの項目名</param>
        public void EA_MenuClick(EA.Repository Repository, string MenuLocation, string MenuName, string ItemName)
        {
            if (ItemName == "&Sample")
            {
                MessageBox.Show("Hello world!");
            }
        }


    }
}
