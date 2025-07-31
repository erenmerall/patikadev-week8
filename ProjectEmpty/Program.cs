var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();




// Controller: Kullanıcılardan gelen HTTP isteklerini karşılayan sınıflardır. 
// Genellikle View (görünüm) veya JSON gibi veri döner. İş mantığını yönlendirir.

// Action: Controller içinde tanımlı, belirli bir isteği (örneğin: /Home/Index) işleyen metottur.

// Model: Uygulamadaki verileri temsil eden sınıflardır. Veritabanı nesneleriyle birebir ilişkilidir.

// View: Kullanıcıya gösterilecek HTML içeriğini oluşturan dosyalardır. Razor ile yazılırlar.

// Razor: C# kodlarının HTML içine gömülebilmesini sağlayan view engine (şablon motorudur). 
// `@` sembolü ile C# kodları yazılır.

// RazorView: Razor motoru ile işlenmiş, HTML olarak tarayıcıya dönen sayfalardır. 
// `.cshtml` dosyalarından oluşur.

// wwwroot: Statik dosyaların (CSS, JS, resimler vb.) yer aldığı klasördür. Tarayıcıdan doğrudan erişilebilir.

// builder.Build(): Web uygulamasının yapılandırılmasını tamamlar ve bir uygulama örneği (WebApplication) üretir.
// Middleware (ara yazılım) pipeline'ı oluşturulmadan önce bu metod çağrılır.

// app.Run(): Yapılandırılmış uygulamayı çalıştırır ve gelen HTTP isteklerini dinlemeye başlar.
// Uygulamanın yaşam döngüsünü başlatır ve bu noktadan sonra uygulama "çalışır" hale gelir.
