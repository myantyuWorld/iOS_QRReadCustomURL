//
//  WKWebViewController.swift
//  QRCodeReader
//
//  Created by 大馬裕一 on 2021/09/14.
//  Copyright © 2021 AppCoda. All rights reserved.
//

import UIKit

class WKWebViewController: UIViewController {
    private let urlString :String = "http://172.16.161.87/hogehoge/KARI001WG_00"
    
    @IBOutlet weak var wkWebView: UIWebView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        let url = URL(string: urlString)!
        let request = URLRequest(url: url)
        
        self.wkWebView.loadRequest(request)
        
        // 例えば、yahooトップページだと、以下で、検索窓に値埋め込みが可能
//        document.forms[0].elements[1].value = "saaa"
    }
    @IBAction func btnJavascriptTapDown(_ sender: Any) {
        print("btnJavascriptTapDown")
        
        var js = "document.getElementById('MainContent_txtRenban').value = 123456"
        let result = wkWebView.stringByEvaluatingJavaScript(from: js)
        print(result)
        
        
    }
}
