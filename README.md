# iOS_QRReadCustomURL

## 【検証１】

1. QRコード読み取り
2. WEB APIリクエスト
3. WEB APIで処理を行い、
4. リクエスト受け取り、カスタムURLスキームで、任意のアプリを立ち上げ

## 【検証２】

1. アプリ内ブラウザで、既存Webシステムの画面を表示
2. アプリのボタンクリックで内臓カメラを起票し、QRコード、バーコードを読み取り
3. Webシステムのテキストボックスに読み取った値を貼り付け

■ 使用が想定される技術
```
[UIWebView・WKWebViewでJavaScriptを実行する方法](https://qiita.com/Howasuto/items/3766e889ec542f5d44a7)
[swiftのwkwebviewでフォームに文字を入力する](https://detail.chiebukuro.yahoo.co.jp/qa/question_detail/q13154101063)
↓
★ できるらしい（未検証）
==========================================================================================
import UIKit
import WebKit

class ViewController: UIViewController {

var webView: WKWebView!

override func viewDidLoad() {
super.viewDidLoad()

let htmlString = "<html><head><title>Hoge</title></head><body><br/><br/><br/><form name=\"form\"><input style\"text\" name=\"text\"></form></body></html>"
webView = WKWebView(frame: self.view.bounds)
webView.loadHTMLString(htmlString, baseURL: nil)
self.view.addSubview(webView)
}

// ボタンを押したら、フォームに「Hello!」を入力。
@IBAction func inputText(sender: AnyObject) {
webView.evaluateJavaScript("document.form.text.value=\"Hello!\"", completionHandler: nil)
}

}
==========================================================================================
```


# 開発時参考

## vitual studio

IIS Expressを公開  
※ 管理者でVisualStudioを実行する必要あり  
https://qiita.com/ledsun/items/ca77c60aad424438cdd7  

## XCode

- info.plist
```
・ URL Types
・ LSApplicationQueriesSchemes
・ Http request許可(https://qiita.com/Howasuto/items/f8e97796c6eb30de4112)
```
