# AddSiriButton Sample for Xamarin.Forms
Xamarin.Formsで作成した、Siriショートカットボタンの最小実装サンプルです。NSUserActivityTypesを使用しました。

## 画面イメージ
![center](Screenshot/center.jpg "center")
![bottom](Screenshot/bottom.jpg "bottom")
![top](Screenshot/top.jpg "top")

左は画面の真ん中にSiriショートカットボタンを配置しています。
```charp:SiriShortcutPageRenderer.cs
this.View.CenterXAnchor.ConstraintEqualTo(siriButton.CenterXAnchor).Active = true;
this.View.CenterYAnchor.ConstraintEqualTo(siriButton.CenterYAnchor).Active = true;
```
真ん中は下付きです。ちょっと不格好になるのでマージンが必要かもしれません。
```charp:SiriShortcutPageRenderer.cs
this.View.CenterXAnchor.ConstraintEqualTo(siriButton.CenterXAnchor).Active = true;
this.View.BottomAnchor.ConstraintEqualTo(siriButton.BottomAnchor).Active = true;
```
右は上付きです。文字とSiriショートカットボタンの配置が重なってしまいました。
```charp:SiriShortcutPageRenderer.cs
this.View.CenterXAnchor.ConstraintEqualTo(siriButton.CenterXAnchor).Active = true;
this.View.TopAnchor.ConstraintEqualTo(siriButton.TopAnchor).Active = true;
```
このように配置位置はiOS側での調整となるため、Xamlの記載に気を付けてください。
見栄えが悪かったり、文字とSiriショートカットボタンの配置が重なるかもしれません。

## 注意事項
Siriショートカットはユーザの利用に応じて設定されるべきです。Siriショートカットボタンの利用目的の明記と、その目的通りにアプリを動かすように実装してください。

## ラインセンス
[LICENCE](LICENSE)
このレポジトリを宣伝いただければ喜びます。

## 参考にしたサイト
* [便利な解錠方法-NSUserActivity-SiriShortcuts解錠](https://akerun.hateblo.jp/entry/2021/09/ios-shortcut)
* [iOS 13におけるSiri Shortcuts 最小実装+α スライド書き起こしと補足](https://tech.studyplus.co.jp/entry/2020/10/16/101530)