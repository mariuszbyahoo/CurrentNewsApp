using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CurrentNewsApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "data" },
                values: new object[] { new Guid("6c0098e5-4894-4d85-9405-4f92fd9fb049"), @"<?xml version=""1.0"" encoding=""UTF-8""?>
<rss version=""2.0"">
   <channel>
      <title>TVN24.pl - Wiadomości - Najnowsze</title>
      <description>Najnowsze wiadomości z kraju i ze świata w TVN24.pl</description>
      <link>https://www.tvn24.pl/</link>
      <language>pl</language>
      <copyright>TVN24</copyright>
       <lastBuildDate>Sat, 19 Oct 19 16:13:07 +0200</lastBuildDate>            <item>
                <title><![CDATA[Gęste mgły w części kraju. Prognoza pogodowych zagrożeń IMGW]]></title>
                <link>https://tvnmeteo.tvn24.pl/r/news/geste-mgly-w-czesci-kraju-br-prognoza-pogodowych-zagrozen-imgw,305468.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-20.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p5/i/519c84155964659375821f7ca576f095/fafb6dbd-19fe-4531-8c47-6fa7e6fd9c82.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Synoptycy Instytutu Meteorologii i Gospodarki Wodnej w części regionów planują wydać ostrzeżenia pierwszego stopnia przed mgłami.
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 16:13:07 +0200</pubDate>
                <guid>https://tvnmeteo.tvn24.pl/r/news/geste-mgly-w-czesci-kraju-br-prognoza-pogodowych-zagrozen-imgw,305468.html</guid>
            </item>
                   <item>
                <title><![CDATA[Poprawka przyjęta, zmiana planów Johnsona. Na ulicach Londynu tłumy]]></title>
                <link>https://www.tvn24.pl/wiadomosci-ze-swiata,2/brexit-glosowanie-nad-umowa-o-wyjsciu-z-ue-przelozone-demonstracje-w-londynie,978758.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-00.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/519c84155964659375821f7ca576f095/bdf855fc-fafd-497f-b69c-8dc29c69c729.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Brytyjska Izba Gmin przyjęła w sobotę poprawkę przewidującą odłożenie głosowania nad poparciem dla umowy brexitowej wynegocjowanej przez gabinet Borisa Johnsona z Unią Europejską. Za poprawką opowiedziało się 322, przeciwko było 306 deputowanych. W związku z tym parlament nie będzie głosował w sobotę nad porozumieniem.
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 08:17:39 +0200</pubDate>
                <guid>https://www.tvn24.pl/wiadomosci-ze-swiata,2/brexit-glosowanie-nad-umowa-o-wyjsciu-z-ue-przelozone-demonstracje-w-londynie,978758.html</guid>
            </item>
                   <item>
                <title><![CDATA[Motocyklista dokonał cudu, by się nie wywrócić. ""Obrona stulecia""]]></title>
                <link>https://eurosport.tvn24.pl/inne,132/alex-marquez-dokonal-cudu-na-torze-motegi-moto2-gp-japonii,978815.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-60.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/519c84155964659375821f7ca576f095/8fb6109c-ffa3-4ced-a822-ccee5966a916.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Alex Marquez dokonał niebywałej rzeczy w trakcie sobotnich kwalifikacji Moto2 przed wyścigiem o GP Japonii. Hiszpański motocyklista, będąc w bardzo trudnej sytuacji na mokrym torze, w ekwilibrystyczny sposób zdołał uchronić się przed upadkiem. Drugą sesję kwalifikacji ukończył na czwartej pozycji.
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 15:57:32 +0200</pubDate>
                <guid>https://eurosport.tvn24.pl/inne,132/alex-marquez-dokonal-cudu-na-torze-motegi-moto2-gp-japonii,978815.html</guid>
            </item>
                   <item>
                <title><![CDATA[Komu bardziej ufamy? Człowiek kontra robot]]></title>
                <link>https://tvn24bis.pl/tech,80/badanie-64-procent-ludzi-bardziej-ufa-robotom-niz-swoim-przelozonym,978821.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-20.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/e74c0d42b4433905293aab661fcf8ddb/e63cb5dd-97f3-48ff-ad7d-959144e02cad.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Z najnowszego badania ""AI at Work"" wynika, że 64 procent ludzi bardziej ufa robotom niż swoim przełożonym. Jak podkreślają twórcy raportu, sztuczna inteligencja zmieniła między innymi relację między ludźmi i technologią w miejscu pracy.
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 15:45:14 +0200</pubDate>
                <guid>https://tvn24bis.pl/tech,80/badanie-64-procent-ludzi-bardziej-ufa-robotom-niz-swoim-przelozonym,978821.html</guid>
            </item>
                   <item>
                <title><![CDATA[Azbest w pudrze dla dzieci. Firma wycofuje produkt]]></title>
                <link>https://tvn24bis.pl/ze-swiata,75/azbest-w-pudrze-dla-dzieci-johnson-johnson-wycofuje-produkt,978805.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-60.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/519c84155964659375821f7ca576f095/280fef18-56b6-4d4d-a38b-c5f2d4f0179b.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Firma Johnson & Johnson wycofała z obrotu partię pudru dla dzieci, po tym jak amerykańska Agencja Żywności i Leków (FDA) wykryła w jednej z próbek ślady rakotwórczego azbestu. Akcje firmy potaniały na zamknięciu notowań na nowojorskiej giełdzie o ponad 6 procent. To kolejne złe wieści dla farmaceutycznego giganta.
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 15:09:48 +0200</pubDate>
                <guid>https://tvn24bis.pl/ze-swiata,75/azbest-w-pudrze-dla-dzieci-johnson-johnson-wycofuje-produkt,978805.html</guid>
            </item>
                   <item>
                <title><![CDATA[Olej z elektrowni w Ostrołęce wyciekł do kanału uchodzącego do Narwi]]></title>
                <link>https://www.tvn24.pl/wiadomosci-z-kraju,3/ostroleka-wyciek-oleju-z-elektrowni-zanieczyszczony-kanal-prowadzacy-do-narwi,978811.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-00.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/519c84155964659375821f7ca576f095/ef556e13-9c04-4a2f-8bac-db071e094d99.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Państwowa Straż Pożarna prowadzi akcję ratunkową w celu opanowania wycieku oleju z elektrowni Energa w Ostrołęce (woj. mazowieckie) do kanału wpływającego do Narwi - poinformował w sobotę oficer prasowy miejscowej Komendy Miejskiej Państwowej Straży Pożarnej młodszy brygadier Robert Chodkowski. - Jesteśmy w stałym kontakcie ze służbami, które monitorują sytuację na miejscu - zapewnił minister środowiska Henryk Kowalczyk.
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 15:05:00 +0200</pubDate>
                <guid>https://www.tvn24.pl/wiadomosci-z-kraju,3/ostroleka-wyciek-oleju-z-elektrowni-zanieczyszczony-kanal-prowadzacy-do-narwi,978811.html</guid>
            </item>
                   <item>
                <title><![CDATA[Spokój w pogodzie? Nie wszędzie. W Tatrach możliwy jest halny]]></title>
                <link>https://tvnmeteo.tvn24.pl/r/news/spokoj-w-pogodzie-nie-wszedzie-w-tatrach-mozliwy-jest-halny,305465.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-00.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p5/i/519c84155964659375821f7ca576f095/b92c8b6e-21b0-48c9-a6ea-dbb1ee15e800.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Najbliższe dni będą słoneczne i pogodne. W niedzielę w Tatrach może jednak wiać halny. Na Kasprowym Wierchu wiatr osiągnie w porywach prędkość nawet 120 kilometrów na godzinę. 
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 14:54:44 +0200</pubDate>
                <guid>https://tvnmeteo.tvn24.pl/r/news/spokoj-w-pogodzie-nie-wszedzie-w-tatrach-mozliwy-jest-halny,305465.html</guid>
            </item>
                   <item>
                <title><![CDATA[Zabawy tercetu MSG. Barcelona już na czele tabeli]]></title>
                <link>https://eurosport.tvn24.pl/pilka-nozna,105/eibar-fc-barcelona-wynik-i-relacja-la-liga,978807.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-e0.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/519c84155964659375821f7ca576f095/46079e3d-e330-49c4-a6f2-8f344944f43b.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Przynajmniej do sobotniego wieczora piłkarze Barcelony będą na czele tabeli Primera Division. To efekt wyjazdowego zwycięstwa w 9. kolejce z Eibarem 3:0.
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 14:51:35 +0200</pubDate>
                <guid>https://eurosport.tvn24.pl/pilka-nozna,105/eibar-fc-barcelona-wynik-i-relacja-la-liga,978807.html</guid>
            </item>
                   <item>
                <title><![CDATA[Kraków chciał refundować in vitro, wojewoda mówi ""nie""]]></title>
                <link>https://www.tvn24.pl/krakow,50/krakow-wojewoda-uniewaznil-uchwale-o-refundacji-in-vitro,978796.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-80.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/f337d999d9ad116a7b4f3d409fcc6480/bb9aeef1-6dcd-4f8e-9a72-3ee1ffc658b9.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Wojewoda małopolski unieważnił w całości uchwałę Rady Miasta Krakowa o dofinansowaniu z budżetu miasta zabiegów in vitro – podał Małopolski Urząd Wojewódzki. Przewodniczący Rady Miasta Dominik Jaśkowiec zapowiedział odwołanie do Wojewódzkiego Sądu Administracyjnego.


                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 14:27:00 +0200</pubDate>
                <guid>https://www.tvn24.pl/krakow,50/krakow-wojewoda-uniewaznil-uchwale-o-refundacji-in-vitro,978796.html</guid>
            </item>
                   <item>
                <title><![CDATA[""Nestor przyniesie obfite opady deszczu, niszczycielski wiatr i sztorm""]]></title>
                <link>https://tvnmeteo.tvn24.pl/r/news/nestor-przyniesie-obfite-opady-deszczu-niszczycielski-wiatr-i-sztorm,305464.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-a0.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p5/i/519c84155964659375821f7ca576f095/148bc31e-22dd-46a6-84c7-76ed8daf30c7.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Nestor jest czternastą nazwaną burzą tropikalną, która uformowała się na Oceanie Atlantyckim. Zmierza w kierunku Florydy. Miejscami może przynieść opady do 150 litrów wody na metr kwadratowy.
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 14:11:52 +0200</pubDate>
                <guid>https://tvnmeteo.tvn24.pl/r/news/nestor-przyniesie-obfite-opady-deszczu-niszczycielski-wiatr-i-sztorm,305464.html</guid>
            </item>
                   <item>
                <title><![CDATA[Kosowo i Rosja nie zagrają w jednej grupie. UEFA podjęła decyzję]]></title>
                <link>https://eurosport.tvn24.pl/pilka-nozna,105/kosowo-nie-zagra-w-grupie-z-rosja-uefa-podjela-decyzje-euro-2020,978804.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-a0.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/519c84155964659375821f7ca576f095/523dd9b5-4c05-433b-86bb-4605480c34d1.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    W piątek UEFA poinformowała, że Rosja i Kosowo nie będą mogły na siebie trafić w fazie grupowej Euro 2020. ""Decyzję podjęto w oparciu o względy bezpieczeństwa"" - napisano w komunikacie europejskiej federacji. Sborna już zapewniła sobie udział w przyszłorocznej imprezie, Kosowo wciąż walczy o historyczny awans. Zaplanowane na 30 listopada losowanie może okazać się bardzo skomplikowane.
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 13:59:33 +0200</pubDate>
                <guid>https://eurosport.tvn24.pl/pilka-nozna,105/kosowo-nie-zagra-w-grupie-z-rosja-uefa-podjela-decyzje-euro-2020,978804.html</guid>
            </item>
                   <item>
                <title><![CDATA[Ruszył Warszawski Salon Jachtowy. ""Nie mamy czego się wstydzić""]]></title>
                <link>https://tvn24bis.pl/z-kraju,74/warszawski-salon-jachtowy-targi-zeglarskie-oraz-sportow-wodnych,978800.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-c0.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/519c84155964659375821f7ca576f095/3cfe2d14-776f-4fe3-80b1-297c630b6a56.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Warszawski Salon Jachtowy to idealne miejsce dla fanów żeglarstwa i targów wodnych. W podwarszawskim Nadarzynie na odwiedzających czekają producenci i dystrybutorzy jachtów żaglowych i motorowych, łodzi sportowych czy kajaków. 
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 13:44:27 +0200</pubDate>
                <guid>https://tvn24bis.pl/z-kraju,74/warszawski-salon-jachtowy-targi-zeglarskie-oraz-sportow-wodnych,978800.html</guid>
            </item>
                   <item>
                <title><![CDATA[Nago okradł łódź. ""Nie jesteśmy miejscem, gdzie ubrania to sprawa opcjonalna""]]></title>
                <link>https://www.tvn24.pl/ciekawostki-michalki,5/floryda-nagi-mezczyzna-okradl-lodz,978792.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-20.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/519c84155964659375821f7ca576f095/c464f036-560a-4179-b816-53d402f3c21f.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Mężczyzna wszedł na jacht i ukradł flagę. Zrobił to kompletnie bez ubrania i wraz ze swoim wspólnikiem ukradł jeszcze część wyposażenia łodzi. Wszystko nagrała kamera. Do niecodziennej kradzieży, pod odsłoną nocy, doszło na Florydzie w Stanach Zjednoczonych. 
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 13:40:53 +0200</pubDate>
                <guid>https://www.tvn24.pl/ciekawostki-michalki,5/floryda-nagi-mezczyzna-okradl-lodz,978792.html</guid>
            </item>
                   <item>
                <title><![CDATA[Lady Gaga spadła ze sceny. Razem ze swoim fanem]]></title>
                <link>https://www.tvn24.pl/kultura-styl,8/lady-gaga-spadla-ze-sceny,978790.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-a0.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/519c84155964659375821f7ca576f095/8a216b0b-9851-4acb-ab33-70a8a630ffe9.jpg?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    Lady Gaga przeżyła dramatyczne chwile na scenie. Amerykańska gwiazda popkultury spadła ze sceny w trakcie koncertu. Razem z zaproszonym na scenę fanem. 
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 13:33:44 +0200</pubDate>
                <guid>https://www.tvn24.pl/kultura-styl,8/lady-gaga-spadla-ze-sceny,978790.html</guid>
            </item>
                   <item>
                <title><![CDATA[Wypadek pod Kłodzkiem. 15-letni kierowca i 17-letni pasażer nie żyją]]></title>
                <link>https://www.tvn24.pl/wroclaw,44/szalejow-dolny-15-letni-kierowca-i-17-letni-pasazer-zgineli-w-wypadku,978793.html?source=rss</link>
                <description>
                    <![CDATA[
                     <img src=""https://r-scale-e0.dcs.redcdn.pl/scale/o2/tvn/web-content/m/p1/i/519c84155964659375821f7ca576f095/bef14762-6403-4b19-8dcb-39e6407832b1.png?type=1&amp;srcmode=4&amp;srcx=0/1&amp;srcy=0/1&amp;srcw=50&amp;srch=50&amp;dstw=50&amp;dsth=50&amp;quality=80"" align=""right"" />                    W Szalejowie Dolnym (Dolnośląskie) osobowe daewoo rozbiło się na przydrożnym drzewie. Autem podróżowało pięciu nastolatków. 15-letni kierowca oraz 17-letni pasażer zginęli na miejscu.
                    ]]>
                </description>
                <pubDate>Sat, 19 Oct 19 13:24:00 +0200</pubDate>
                <guid>https://www.tvn24.pl/wroclaw,44/szalejow-dolny-15-letni-kierowca-i-17-letni-pasazer-zgineli-w-wypadku,978793.html</guid>
            </item>
    </channel>
</rss>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
