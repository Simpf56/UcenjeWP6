using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MojProjekat.KonzolnaAplikacija.Modeli;

namespace MojProjekat.KonzolnaAplikacija
{
    internal class Izbornik
    {

        public ObradaKupac ObradaKupac { get; set; }
        public ObradaPutovanje ObradaPutovanje { get; set; }
        public ObradaGrupa ObradaGrupa { get; set; }

        public Izbornik()
        {
            Pomocno.DEV = true;
            ObradaKupac = new ObradaKupac();
            ObradaPutovanje = new ObradaPutovanje();
            ObradaGrupa = new ObradaGrupa(this);
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void UcitajPodatke()
        {
            string docPath =
         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists(Path.Combine(docPath, "putovanja.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "putovanja.json"));
                ObradaPutovanje.Putovanja = JsonConvert.DeserializeObject<List<Putovanje>>(file.ReadToEnd());
                file.Close();

            }

        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Putovanja");
            Console.WriteLine("2. Kupci");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {

            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 4))
            {
                case 1:
                    Console.Clear();
                    ObradaPutovanje.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    ObradaKupac.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    ObradaGrupa.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja!");
                    SpremiPodatke();
                    break;
            }
        }

        private void SpremiPodatke()
        {
            if (Pomocno.DEV)
            {
                return;
            }

            //Console.WriteLine(JsonConvert.SerializeObject(ObradaSmjer.Smjerovi));

            string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "putovanja.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ObradaPutovanje.Putovanja));
            outputFile.Close();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*** SimpfAntonijo Console App v 1.0 ***");
            Console.WriteLine("*********************************");
        }
    }
}