﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core.Preview;
using Windows.UI.Xaml.Controls;

namespace UF12
{
  partial class MainPage
  {
    //void SetupCloseRequestedHandler()
    //{
    //  // [×]ボタンのイベントハンドラー (1703以降)
    //  // ※マニフェストに <rescap:Capability Name="confirmAppClose"/> が必要
    //  SystemNavigationManagerPreview.GetForCurrentView().CloseRequested += async (s, e) =>
    //    {
    //      // 閉じられるのをキャンセルする
    //      e.Handled = true;

    //      ContentDialog dialog = new ContentDialog
    //      {
    //        Title = "アプリを終了しますか?",
    //        Content = "[×] ボタンが押されましたが、アプリを終了してもよいですか",
    //        CloseButtonText = "キャンセル",
    //        PrimaryButtonText = "終了",
    //        //SecondaryButtonText = "Try it",
    //        DefaultButton = ContentDialogButton.Primary
    //      };
    //      ContentDialogResult result = await dialog.ShowAsync();
    //      if (result == ContentDialogResult.Primary)
    //      {
    //        // キャンセルしてしまっているので、
    //        // 必要ならばあらためてアプリを終了させる。
    //        App.Current.Exit();
    //        // ↑Exitすると、OnSuspending等は実行されないので注意!
    //      }
    //    };
    //}
  }
}