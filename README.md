# KindleUnlimitedSearch
Kindle Unlimited 本の検索補助

## はじめに

Kindle Unlimited で利用可能な電子書籍の検索しづらさに閉口していたところ、
Quita で yoshifumi murakami 氏の 
[kindle unlimited検索を作ってみた](https://qiita.com/muranet/items/4bb0c89f6c2da44185a9)
という記事を発見。

それに基づいてC#で作ってみたものです。

## ビルド

Microsoft Visual Studio 2017 Community でビルドしています。


## 利用方法

1. 起動する
2. 検索したい文字列を入力する
3. Browser ボタンを押すと、既定のブラウザで検索画面が開く

Browser ボタンの代わりに Clipboard ボタンを押すと、クリップボードへコピーします。


## ライセンス

MIT ライセンスです。

```
MIT License

Copyright (c) 2019 Toshihiko Ichida

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

## 謝辞

非常に有用な記事を公開してくださった、yoshihisa murakami 氏に感謝します。
