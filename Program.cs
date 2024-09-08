// See https://aka.ms/new-console-template for more information

// aşağıdaki örnekte, a bir parantez içerisinde tanımlandığı için, parantez bitiminde, a bellekten düşer.

// tüm yazılım içeirisndeki tüm parantezlerin içerisinden erişebilir olmak için en tepede tanımalama yapabiliriz.


int gama = 40;
{
   int a = 10;
   
}

// a bellenten düştü.
//Console.WriteLine(a);

// düşmemesi için a değişkenini bir üst scope'da tanımlamalısınız. Örnek 
// a parantezlerin içerisinde olursa, parantez bitimine a bellekten düşer. Onun için, a'nın tanımını daha üst scope'de yaptık ve parantez içerisinde değerini atadık.
int a;
{
    a =10;


}
Console.WriteLine(a);



// aşağıdaki her iki değişkende parantezler içerisinde tanımlı olduğu için parantez içerisinden erişmeye çalıştığınızda, ulaşamazsınız, çünkü parantez bitiminde bellekten düşeceklerdir.

{
    int b = 20;
    // c ye erişilemez
}
{
    // b ye erişilemez
    int c = 30;
}
// b ve c ye erişilemez.
{
    int x = 10;
    {
       // x'ye erişilir.
       // çünkü x bir dıştaki parantezler kadar yaşayacaktır.        
    }
}

// Kural Önemli : Yazılım gelitirme yaparken, tüm program içerisinde ihtiyacınız olan değişkenleri, en üste yazmanız tavsiye edilir.
// hesaplamalar için kullanılan ve başka hiç bir şey için ihtiyaç olmayan değişkenleri ihtiyaç olunan yerde tanımlayabilirsiniz.