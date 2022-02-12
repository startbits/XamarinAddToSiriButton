# AddSiriButton Sample for Xamarin.Forms
Xamarin.Formsで作成した、Siriショートカットボタンの最小実装サンプルです。NSUserActivityTypesを使用しました。

コミットを見ればおおよその実装はわかると思います。
* [Info.plist](XamarinAddToSiriButton/XamarinAddToSiriButton.iOS/Info.plist#L37-L40)
* [ShortcutAction.cs](XamarinAddToSiriButton/XamarinAddToSiriButton.iOS/ShortcutAction.cs)
* [SiriShortcutPageRenderer.cs](XamarinAddToSiriButton/XamarinAddToSiriButton.iOS/SiriShortcutPageRenderer.cs)
  * 少し[強引なこと](XamarinAddToSiriButton/XamarinAddToSiriButton.iOS/SiriShortcutPageRenderer.cs#L13)
をしています。MAUIだとどうなるのでしょうか。

## 画面イメージ
![center](Screenshot/center.jpg "center")
![bottom](Screenshot/bottom.jpg "bottom")
![top](Screenshot/top.jpg "top")

1つ目は
[コミット](XamarinAddToSiriButton/XamarinAddToSiriButton.iOS/SiriShortcutPageRenderer.cs#L28-L29)
しているのと同じ設定で、画面の真ん中にSiriショートカットボタンを配置しています。
```charp
this.View.CenterXAnchor.ConstraintEqualTo(siriButton.CenterXAnchor).Active = true;
this.View.CenterYAnchor.ConstraintEqualTo(siriButton.CenterYAnchor).Active = true;
```
2つ目以降は別で試したものでコミットしていません。
2つ目は下付きです。ちょっと不格好になるのでマージンが必要かもしれません。
```charp
this.View.CenterXAnchor.ConstraintEqualTo(siriButton.CenterXAnchor).Active = true;
this.View.BottomAnchor.ConstraintEqualTo(siriButton.BottomAnchor).Active = true;
```
3つ目は上付きです。文字とSiriショートカットボタンの配置が重なってしまいました。
```charp
this.View.CenterXAnchor.ConstraintEqualTo(siriButton.CenterXAnchor).Active = true;
this.View.TopAnchor.ConstraintEqualTo(siriButton.TopAnchor).Active = true;
```
このように配置位置はiOS側での調整となるため、Xamlの記載に気を付けてください。
見栄えが悪かったり、文字とSiriショートカットボタンの配置が重なるかもしれません。

## 注意事項
Siriショートカットはユーザの利用に応じて設定されるべきです。Siriショートカットボタンの利用目的の明記と、その目的通りにアプリを動かすように実装してください。

## 参考にしたサイト
* [便利な解錠方法-NSUserActivity-SiriShortcuts解錠](https://akerun.hateblo.jp/entry/2021/09/ios-shortcut)
* [iOS 13におけるSiri Shortcuts 最小実装+α スライド書き起こしと補足](https://tech.studyplus.co.jp/entry/2020/10/16/101530)