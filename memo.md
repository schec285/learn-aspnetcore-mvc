# 学習記録

## SEカレッジを見る

過去に見てた。VS Codeで環境構築するのでいい機会にはなるが、.NET開発はvisual studio使うのがあんぱいに感じる。

## 公式チュートリアルを読む

[ASP.NET Core MVCの公式チュートリアル](https://learn.microsoft.com/ja-jp/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-9.0&tabs=visual-studio)を読めば大体分かりそう。
概要で構築を学び、MVCの基本はコマンドで生成させる様子。

以下のことが学べたので、ある程度基本的なことは体系的に学べるようになっていたと思う。

* MVCの基本と実装の仕方
* スキャフォールディングツールを使ったCRUDページの生成
* ORM([EF](https://learn.microsoft.com/ja-jp/ef/core/modeling/entity-properties?tabs=data-annotations%2Cwith-nrt))とマイグレーション生成や更新の使い方
	* `Add-Migration InitialCreate`
		* DDLとなるマイグレーションファイル生成
	* `Update-Database`
		* 最新のマイグレーションをスキーマに適用
	* `Add-Migration Rating`
		* DMLとなるマイグレーションファイル生成、Ratingはファイル名に付与されるので、分かりやすい名称にするとよい
* シードによるテストデータの作成

特に後半はModelとControllerのより詳しくて便利な使い方の説明があった。