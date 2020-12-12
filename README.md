# FitForScreen uGUIのImageを画面にフィットさせる
Dynamically fit uGUI Image to the screen. You can select Stretch, Fit, Fill.  
tags: Unity uGUI

# 前提
- unity 2018.4.30f1で動作確認しました。

# 「画面にフィットさせる」とは?

画面への合わせ方として、以下の3種類が考えられます。

|名称|イメージ|説明|
|:---|:--:|:---|
|Stretch<br>伸縮|![Stretch.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/365845/20efb37d-22e9-822d-6b69-ea0ec9eaf7dd.png)|縦横比を無視して、画面いっぱいに拡縮する|
|Fit<br>内接|![Fit.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/365845/a23ee559-c618-5ba1-8035-d115c99adba5.png)|縦横比を保ち、画像全体が表示されるように拡縮する<br>画像と画面端に隙間ができる|
|Fill<br>外接|![Fill.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/365845/51adb1c0-e8b3-5501-2c2e-b06aff66ab9d.png)|縦横比を保ち、画面に隙間なく表示されるように拡縮する<br>画像が画面からはみ出す|

# Stretch / Fit の場合

「Stretch - 伸縮」と「Fit - 内接」は、unityの標準機能だけで容易に実現できますね。  
![Inspecter.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/365845/04d21523-c3d9-ce71-5ee8-33618fa0cae7.png)  
RectTransformを、ルートCanvasの外周に沿って拡縮するように設定して、ImageのPreserv Aspectをチェックすると「Fit」、チェックしなければ「Stretch」になります。  
また、こうするだけで、スマホの回転時などに生じる画面サイズ変化にも対応できます。

# Fill の実現

## 使い方

- プロジェクトにアセットをインポートしてください。
- シーンのオブジェクトに、"FitForScreen"スクリプトをアタッチしてください。
- インスペクタでImageを設定し、Methodを選んでください。
- 画面サイズやMethodの変化にも対応しています。
- サンプル(SampleScene)も参考にしてください。

![Inspecter3.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/365845/a0b810eb-18c3-224b-3929-605301815eef.png) 　![SS4.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/365845/35aabb51-e48e-79e7-7088-e4bd1d73f3ec.png)  
[UNITY-CHAN! © Unity Technologies Japan/UCL](http://unity-chan.com/)
