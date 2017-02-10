using EA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AddinMainWithWindow
{
    [ComVisible(true)]
    [Guid("21C25D1F-EADE-42DD-8AD2-FA575D89149E")]
    public interface IComClassInterface
    {
        /// <summary>
        /// EAコネクトイベント
        /// </summary>
        /// <param name="Repository">EAリポジトリ</param>
        /// <returns>アドインの種類</returns>
        [DispId(1)]
        string EA_OnPostInitialized(Repository Repository);

        /// <summary>
        /// メニューアイテムうの取得
        /// </summary>
        /// <param name="Repository">EAリポジトリ</param>
        /// <param name="MenuLocation">メニューが呼ばれた位置</param>
        /// <param name="MenuName">親メニューの項目名</param>
        /// <returns>メニューの項目名</returns>
        [DispId(2)]
        object EA_GetMenuItems(Repository Repository, string MenuLocation, string MenuName);

        /// <summary>
        /// メニュー項目のステータス取得
        /// </summary>
        /// <param name="Repository">EAリポジトリ</param>
        /// <param name="MenuLocation">メニューが呼ばれた位置</param>
        /// <param name="MenuName">親メニューの項目名</param>
        /// <param name="ItemName">メニューの項目名</param>
        /// <param name="IsEnabled">選択可否</param>
        /// <param name="IsChecked">チェック表示</param>
        [DispId(3)]
        void EA_GetMenuState(Repository Repository, string MenuLocation, string MenuName, string ItemName, ref bool IsEnabled, ref bool IsChecked);

        /// <summary>
        /// メニュー項目のクリックイベント
        /// </summary>
        /// <param name="Repository">EAリポジトリ</param>
        /// <param name="MenuLocation">メニューが呼ばれた位置</param>
        /// <param name="MenuName">親メニューの項目名</param>
        /// <param name="ItemName">メニューの項目名</param>
        [DispId(4)]
        void EA_MenuClick(EA.Repository Repository, string MenuLocation, string MenuName, string ItemName);
    }
}
