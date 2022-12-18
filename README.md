# mcezmezhackathon

## Proje Amacı
Firmanın onay ve zaman kısıtları ile sipariş oluşturması.</br>
## ÖZET
.NET Core 6 Apı,MSSQL, Entity Framework kullanılarak yazılmış bir firmaların, ürünlerin kayıt edilidiği ve siparişlerinin zaman ve firmanın onayına göre 
oluşturulduğu bir Apı uygulaması. </br> 
Veri tabanı işlemleri code fist yaklaşımı ile projeye dahil edilmiştir. Code first yaklaşımının amacı veri tabanı işlemlerini Sql Management Studio üzerinden değil
projemiz üzerinden daha kolay erişebilmektir.</br>
Sql Management Studio ile sadece tablo ilişkileri için kullanılmıştır.</br>
Örneğin bir satış oluşturucaksanız firma onaylı değilse oluşurma başarısız olarak messaj gösteriliyor. Firma sipariş </br>
oluşurma saati dışında ise sipariş oluşurmaya izin vermiyor.
## Teknolojiler
.NET Core 6 API ,MSSSQL ,Swagger UI, Entity FrameWork Code First </br>
## Gereklilikler
Microsoft.EntityFrameworkCore.Tools </br>
Microsoft.EntityFrameworkCore.SqlServer </br>
Paketlerini kurmanız gerekmektedir </br>

