using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public class Empresa
    {
        //Exercicio 1

        List<Aviao> planes = new List<Aviao>();
        List<AeronaveComercial> comercial = new List<AeronaveComercial>();
        List<AeronaveMercadorias> cargos = new List<AeronaveMercadorias>();
        List<AeronaveParticular> jets = new List<AeronaveParticular>();
        List<Avioneta> smallPlanes = new List<Avioneta>();

        //Booking Lists
        List<Marcacao> smallPlanesBooking = new List<Marcacao>();
        List<Marcacao> planesBooking = new List<Marcacao>();
        List<Marcacao> comercialBooking = new List<Marcacao>();
        List<Marcacao> cargosBooking = new List<Marcacao>();
        List<Marcacao> jetsBooking = new List<Marcacao>();

        List<Marcacao> geralBooking = new List<Marcacao>();
        List<Marcacao> ManutencoesBooking = new List<Marcacao>();

        //List of new available planes
        List<string> changedToAvailableFromMaintenance = new List<string>();
        List<string> changedToAvailableFromFreight = new List<string>();

        //Exercicio 2

        //PLANE FILE
        public void AddAviao(Aviao aviao) //adicionar avião á lista
        {
            planes.Add(aviao);
        }

        public void UpdateAviaoFile() //copies planes list to the plane file
        {
            StreamWriter file = new StreamWriter(@"planes.csv");

            foreach (Aviao aviao in planes)
            {
                file.WriteLine(aviao.Id + ";" + aviao.Model + ";" + aviao.Capacity + ";" + aviao.Autonomy + ";" + aviao.MaintenanceDate + ";" + aviao.Activity + ";" + aviao.EngineQuantity + ";" + aviao.Brand + ";" + aviao.ManufacturingYear);
            }
            file.Close();
        }

        //AERONAVECOMERCIAL FILE

        public void AddAeronaveComercial(AeronaveComercial aeronave) //adds comercial do the comercial planes list
        {
            comercial.Add(aeronave);
        }

        public void UpdateAeronaveComercialFile() //copies comercials list to the comercials file
        {
            StreamWriter file = new StreamWriter(@"comercial.csv");

            foreach (AeronaveComercial aeronave in comercial)
            {
                file.WriteLine(aeronave.Id + ";" + aeronave.Model + ";" + aeronave.Capacity + ";" +
                               aeronave.Autonomy + ";" + aeronave.MaintenanceDate + ";" + aeronave.Activity + ";" +
                               aeronave.EngineQuantity + ";" + aeronave.Brand + ";" + aeronave.ManufacturingYear + ";" +
                               aeronave.DailyFlightsNumber + ";" + aeronave.Airline);
            }
            file.Close();
        }

        //AERONAVEMERCADORIAS
        public void AddAeronaveMercadorias(AeronaveMercadorias aeronave) //adds comercial do the comercial planes list
        {
            cargos.Add(aeronave);
        }

        public void UpdateAeronaveMercadoriasFile() //copies the cargo list to the cargos file
        {
            StreamWriter file = new StreamWriter(@"cargos.csv");

            foreach (AeronaveMercadorias aeronave in cargos)
            {
                file.WriteLine(aeronave.Id + ";" + aeronave.Model + ";" + aeronave.Capacity + ";" +
                               aeronave.Autonomy + ";" + aeronave.MaintenanceDate + ";" + aeronave.Activity + ";" +
                               aeronave.EngineQuantity + ";" + aeronave.Brand + ";" + aeronave.ManufacturingYear + ";" +
                               aeronave.CargoCapacity + ";" + aeronave.FreightValue);
            }
            file.Close();
        }


        //AERONAVEPARTICULAR FILE
        public void AddAeronaveParticular(AeronaveParticular aeronave) //adds comercial do the comercial planes list
        {
            jets.Add(aeronave);
        }

        public void UpdateAeronaveParticularFile() //copies the jets list to the jets file
        {
            StreamWriter file = new StreamWriter(@"jets.csv");

            foreach (AeronaveParticular aeronave in jets)
            {
                file.WriteLine(aeronave.Id + ";" + aeronave.Model + ";" + aeronave.Capacity + ";" +
                               aeronave.Autonomy + ";" + aeronave.MaintenanceDate + ";" + aeronave.Activity + ";" +
                               aeronave.EngineQuantity + ";" + aeronave.Brand + ";" + aeronave.ManufacturingYear + ";" +
                               aeronave.OwnersNumber + ";" + aeronave.FreightValue);
            }
            file.Close();
        }

        //AVIONETA FILE

        public void AddAvioneta(Avioneta avioneta) //adds small Plane do the small planes list
        {
            smallPlanes.Add(avioneta);
        }

        public void UpdateAvionetaFile() //copies the small Planes list to the small Planes file
        {
            StreamWriter file = new StreamWriter(@"smallPlanes.csv");

            foreach (Avioneta avioneta in smallPlanes)
            {
                file.WriteLine(avioneta.Id + ";" + avioneta.Model + ";" + avioneta.Capacity + ";" +
                               avioneta.Autonomy + ";" + avioneta.MaintenanceDate + ";" + avioneta.Activity + ";" +
                               avioneta.EngineQuantity + ";" + avioneta.Brand + ";" + avioneta.ManufacturingYear + ";" +
                               avioneta.MinimumLandingArea + ";" + avioneta.MinimumTakeoffArea + ";" + avioneta.FreightValue);
            }
            file.Close();
        }

        //Update Planes Files
        public void ReadAvioneta() //reads the small planes files
        {
            StreamReader file = new StreamReader(@"smallPlanes.csv");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                if (!string.IsNullOrWhiteSpace(fields[0]))
                {
                    Avioneta avioneta = new Avioneta(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), double.Parse(fields[9]), double.Parse(fields[10]), double.Parse(fields[11]));
                    smallPlanes.Add(avioneta);
                }
            }
            file.Close();

        }
        public void ReadAeronaveComercial() //reads the comercials files
        {
            StreamReader file = new StreamReader(@"comercial.csv");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                if (!string.IsNullOrWhiteSpace(fields[0]))
                {
                    AeronaveComercial aeronave = new AeronaveComercial(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), int.Parse(fields[9]), fields[10]);
                    comercial.Add(aeronave);
                }
            }
            file.Close();
        }
        public void ReadAeronaveMercadorias() //reads the cargo files
        {
            StreamReader file = new StreamReader(@"cargos.csv");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                if (!string.IsNullOrWhiteSpace(fields[0]))
                {
                    AeronaveMercadorias aeronave = new AeronaveMercadorias(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), int.Parse(fields[9]), int.Parse(fields[10]));
                    cargos.Add(aeronave);
                }
                
            }
            file.Close();
        }
        public void ReadAeronaveParticular() //reads the jets file
        {
            StreamReader file = new StreamReader(@"jets.csv");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                if (!string.IsNullOrWhiteSpace(fields[0]))
                {
                    AeronaveParticular aeronave = new AeronaveParticular(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), int.Parse(fields[9]), int.Parse(fields[10]));
                    jets.Add(aeronave);
                }
            }
            file.Close();
        }
        public void ReadAviao() //reads planes file
        {
            StreamReader file = new StreamReader(@"planes.csv");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                if (!string.IsNullOrWhiteSpace(fields[0]))
                {
                    Aviao aviao = new Aviao(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]));
                    planes.Add(aviao);
                }
            }
            file.Close();
        }

        //Exercicio 2 

        //Exercicio2- a)

        public void ReadAllFiles() //reads all files
        {
            ReadAeronaveComercial();
            ReadAeronaveMercadorias();
            ReadAeronaveParticular();
            ReadAviao();
            ReadAvioneta();
            ReadAviaoBooking();
            ReadAvionetaBooking();
            ReadAeronaveParticularBooking();
            ReadAeronaveMercadoriasBooking();
            ReadAeronaveComercialBooking();
            ReadGeralBookingFile();
            ReadManutencaoFile();
        }

        public int NumberOfPlanes() //returns the number of existing planes and adds one 
        {
            int planecounter = 0;
            foreach (Aviao aviao in planes)
            {
                planecounter++;
            }
            foreach (AeronaveComercial comercialPlane in comercial)
            {
                planecounter++;
            }
            foreach (AeronaveMercadorias cargoPlane in cargos)
            {
                planecounter++;
            }
            foreach (AeronaveParticular jetPlane in jets)
            {
                planecounter++;
            }
            foreach (Avioneta smallPlane in smallPlanes)
            {
                planecounter++;
            }

            return planecounter + 1;
        }

        //Exercicio2 - b)

        //Change planes State

        public void ChangeAvionetaState(int id, string state) //changes a small Plane State
        {
            //searches for the planes 
            foreach (Avioneta avioneta in smallPlanes)
            {
                //changes the state 
                if (avioneta.Id == id)
                {
                    avioneta.Activity = state;
                }
            }
            UpdateAvionetaFile(); //copies the list to the file
        }

        public void ChangeAviaoState(int id, string state) //changes a Plane State
        {
            //searches for the planes
            foreach (Aviao aviao in planes)
            {
                //changes the state 
                if (aviao.Id == id)
                {
                    aviao.Activity = state;
                }
            }
            UpdateAviaoFile(); //copies the list to the file
        }

        public void ChangeAeronaveParticularState(int id, string state) //changes a Jet State
        {
            //searches for the planes
            foreach (AeronaveParticular jet in jets)
            {
                //changes the state 
                if (jet.Id == id)
                {
                    jet.Activity = state;
                }
            }

            UpdateAeronaveParticularFile(); //copies the list to the file
        }

        public void ChangeAeronaveMercadoriasState(int id, string state) //changes a cargo State
        {
            //searches for the planes
            foreach (AeronaveMercadorias cargo in cargos)
            {
                //changes the state 
                if (cargo.Id == id)
                {
                    cargo.Activity = state;
                }
            }

            UpdateAeronaveMercadoriasFile(); //copies the list to the file
        }

        public void ChangeAeronaveComercialState(int id, string state) //changes a comercial State
        {
            //searches for the planes
            foreach (AeronaveComercial aeronavecomercial in comercial)
            {
                //changes the state 
                if (aeronavecomercial.Id == id)
                {
                    aeronavecomercial.Activity = state;
                    break;
                }
            }
            UpdateAeronaveComercialFile(); //copies the list to the file
        }


        //LOGIN SYSTEM

        public bool VerifiesLogin(string username, string password) //verifies the login inputs
        {
            //If the login data are correct returns true else returns false

            StreamReader file = new StreamReader(@"users.csv");

            string line;

            //Reads the entire file line by line
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');

                //if the username and the password match
                if (fields[0] == username && fields[1] == password)
                {
                    MessageBox.Show("Welcome " + fields[2] + "!");
                    return true; //returns true
                    
                }
            }

            file.Close();
            MessageBox.Show("Username or Password Wrong!\nPlease Try Again.");
            return false; //if the user or password are wrong return false
        }

        public string AccountPermission(string username, string password)
        {
            //If the login data are correct returns true else returns the account permission

            StreamReader file = new StreamReader(@"users.csv");

            string line;

            //Reads the entire file line by line
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');

                //if the username and the password match
                if (fields[0] == username && fields[1] == password)
                {
                    return fields[3]; //returns the permission

                }
            }
            file.Close();
            return "no";

        }

        public void VerifySpace (string username, string password) //verifies if there are spaces
        {
            foreach(char c in username)
            {
                if (c == ' ')
                {
                    MessageBox.Show("The username cannot contain spaces"); //verifies if there are spaces in the username input
                    return;
                }
            }
            foreach(char c in password)
            {
                if (c == ' ')
                {
                    MessageBox.Show("The password cannot contain spaces"); //verifies if there are spaces in the password input
                    return;
                }
            }
        }

        //Booking

        public void ReadAvionetaBooking()  //reads Small Planes Booking

        {

            StreamReader file = new StreamReader(@"smallPlanesBooking.csv");

            string line;

            while ((line = file.ReadLine()) != null)

            {

                string[] fields = line.Split(';');

                int id;
                string model;
                string date1, date2;

                if (fields.Length == 2)
                {
                    Marcacao marcacao = new Marcacao(fields[0], fields[1], fields[2]);
                    smallPlanesBooking.Add(marcacao);

                }



            }

            file.Close();

        }

        public void ReadAviaoBooking() //reads Planes Booking

        {

            StreamReader file = new StreamReader(@"planesBooking.csv");

            string line;

            while ((line = file.ReadLine()) != null)

            {

                string[] fields = line.Split(';');
                if (fields.Length == 2)
                {
                    Marcacao marcacao = new Marcacao(fields[0], fields[1], fields[2]);
                    planesBooking.Add(marcacao);

                }



            }

            file.Close();

        }

        public void ReadAeronaveComercialBooking() //reads Comercials Booking

        {

            StreamReader file = new StreamReader(@"comercialBooking.csv");

            string line;

            while ((line = file.ReadLine()) != null)

            {

                string[] fields = line.Split(';');

                if (fields.Length == 2)
                {
                    Marcacao marcacao = new Marcacao(fields[0], fields[1], fields[2]);
                    comercialBooking.Add(marcacao);

                }

            }

            file.Close();

        }

        public void ReadAeronaveMercadoriasBooking() //reads Cargos Booking

        {

            StreamReader file = new StreamReader(@"cargoBooking.csv");

            string line;

            while ((line = file.ReadLine()) != null)

            {

                string[] fields = line.Split(';');
                if (fields.Length == 3)
                {
                    Marcacao marcacao = new Marcacao(fields[0], fields[1], fields[2]);

                    cargosBooking.Add(marcacao);
                }



            }

            file.Close();

        }

        public void ReadAeronaveParticularBooking() //reads Jets Booking
        {
            StreamReader file = new StreamReader(@"jetsBooking.csv");

            string line;

            while ((line = file.ReadLine()) != null)
            {

                string[] fields = line.Split(';');
                if (fields.Length == 3)
                {
                    Marcacao marcacao = new Marcacao(fields[0], fields[1], fields[2]);

                    jetsBooking.Add(marcacao);
                }


            }
            file.Close();
        }

        public void UpdateJetsBookingFile()  //copies the Jet booking to the Jet booking file
        {
            StreamWriter file = new StreamWriter(@"jetsBooking.csv");

            foreach (Marcacao marcacao in jetsBooking)
            {
                file.WriteLine(marcacao.Id + ";" + marcacao.StartDate + ";" + marcacao.EndDate);
            }
            file.Close();
        }

        public void UpdateSmallPlanesBookingFile()   //copies the Small Planes booking to the Small Planes booking file
        {
            StreamWriter file = new StreamWriter(@"smallPlanesBooking.csv");

            foreach (Marcacao marcacao in smallPlanesBooking)
            {
                file.WriteLine(marcacao.Id + ";" + marcacao.StartDate + ";" + marcacao.EndDate);
            }
            file.Close();
        }

        public void UpdatePlanesBookingFile()   //copies the Planes booking to the Planes booking file
        {
            StreamWriter file = new StreamWriter(@"planesBooking.csv");

            foreach (Marcacao marcacao in planesBooking)
            {
                file.WriteLine(marcacao.Id + ";" + marcacao.StartDate + ";" + marcacao.EndDate);
            }
            file.Close();
        }

        public void UpdateComercialBookingFile() //copies the Comercial booking to the Comercial booking file
        {
            StreamWriter file = new StreamWriter(@"comercialBooking.csv");

            foreach (Marcacao marcacao in comercialBooking)
            {
                file.WriteLine(marcacao.Id + ";" + marcacao.StartDate + ";" + marcacao.EndDate);
            }
            file.Close();
        }

        public void UpdateCargoBookingFile() //copies the Cargo booking to the Cargo booking file
        {
            StreamWriter file = new StreamWriter(@"cargoBooking.csv");

            foreach (Marcacao marcacao in cargosBooking)
            {
                file.WriteLine(marcacao.Id + ";" + marcacao.StartDate + ";" + marcacao.EndDate);
            }
            file.Close();
        }
        public void ReadBooking() //Reads every booking
        {
            ReadAvionetaBooking();
            ReadAviaoBooking();
            ReadAeronaveComercialBooking();
            ReadAeronaveMercadoriasBooking();
            ReadAeronaveParticularBooking();
            ReadGeralBookingFile();
        }

        public bool VerifyAvailability(int id, string datetime1, string datetime2) //Verifies if there is a maintenance for this planes for the inputed date
        {
            string data1 = DateTime.Parse(datetime1).ToString();
            string data2 = DateTime.Parse(datetime2).ToString();

            foreach (Marcacao marcacao in ManutencoesBooking)
            {
                if(marcacao.Id == id.ToString())
                {
                    if (DateTime.Parse(datetime1) >= DateTime.Parse(marcacao.StartDate) && DateTime.Parse(datetime1) <= DateTime.Parse(marcacao.EndDate))
                    {
                        return true;
                    }
                    else if (DateTime.Parse(datetime2) >= DateTime.Parse(marcacao.StartDate) && DateTime.Parse(datetime2) <= DateTime.Parse(marcacao.EndDate))
                    {
                        return true;
                    }
                    else if (DateTime.Parse(datetime1) <= DateTime.Parse(marcacao.StartDate) && DateTime.Parse(datetime2) >= DateTime.Parse(marcacao.EndDate))
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
        public bool VerifyAvailabilityBooking(int id,string datetime1, string datetime2) //Verifies if there is a booking for this planes for the inputed date
        {
            
            foreach(Marcacao marca in geralBooking)
            {
                if(marca.Id == id.ToString())
                {
                    if (DateTime.Parse(datetime1) >= DateTime.Parse(marca.StartDate) && DateTime.Parse(datetime1) <= DateTime.Parse(marca.EndDate))
                    {
                        return true;
                    }
                    else if (DateTime.Parse(datetime2) >= DateTime.Parse(marca.StartDate) && DateTime.Parse(datetime2) <= DateTime.Parse(marca.EndDate))
                    {
                        return true;
                    }
                    else if (DateTime.Parse(datetime1) <= DateTime.Parse(marca.StartDate) && DateTime.Parse(datetime2) >= DateTime.Parse(marca.EndDate))
                    {
                        return true;
                    }

                }
               
            }
            return false;
        }
        
        public bool VerifyAvailabilityMaintenance(int id,string datetime1, string datetime2)  //Verifies if there is a maintenance for this planes for the inputed date
        {
            
            foreach (Marcacao marca in ManutencoesBooking)
            {
                if (marca.Id == id.ToString())
                {
                    MessageBox.Show(DateTime.Parse(datetime1).ToString());
                    MessageBox.Show(DateTime.Parse(marca.StartDate).ToString());

                    if (DateTime.Parse(datetime1) >= DateTime.Parse(marca.StartDate) && DateTime.Parse(datetime1) <= DateTime.Parse(marca.EndDate))
                    {
                        return true;
                    }
                    else if (DateTime.Parse(datetime2) >= DateTime.Parse(marca.StartDate) && DateTime.Parse(datetime2) <= DateTime.Parse(marca.EndDate))
                    {
                        return true;
                    }
                    else if (DateTime.Parse(datetime1) <= DateTime.Parse(marca.StartDate) && DateTime.Parse(datetime2) >= DateTime.Parse(marca.EndDate))
                    {
                        return true;
                    }
                    else if (DateTime.Parse(datetime1) <= DateTime.Parse(marca.StartDate) && DateTime.Parse(datetime2) >= DateTime.Parse(marca.EndDate))
                    {
                        return true;
                    }

                }
                
            }
            return false;
        }


        public string SearchId(int id, string date1, string date2, DateTime datetime1, DateTime datetime2) //Searches for the plane and Adds the Booking to the planes Booking
        {
            Marcacao marcacao = new Marcacao(id.ToString(), date1, date2);

            foreach (Aviao a in planes) //if the inputed plane is a plane 
            {
                if (a.Id == id) //creates the new Marcacao and adds it to the bookings list
                {
                    Marcacao marcacaoPrice = new Marcacao(id.ToString(), "0", date1, date2);
                    geralBooking.Add(marcacaoPrice);
                    planesBooking.Add(marcacao);
                    UpdateGeralBookingFile(); //Updates the Geral Booking File
                    UpdatePlanesBookingFile(); //Updates the Plane Booking File
                    return "Planes";
                }
            }
            foreach (AeronaveComercial a in comercial) //if the inputed plane is a comercial 
            {
                if (a.Id == id)
                {
                    Marcacao marcacaoPrice = new Marcacao(id.ToString(), "0", date1, date2);
                    geralBooking.Add(marcacaoPrice);
                    comercialBooking.Add(marcacao);
                    UpdateGeralBookingFile();
                    UpdateComercialBookingFile();
                    return "CommercialPlane";
                }
            }
            foreach (AeronaveMercadorias a in cargos) //if the inputed plane is a cargo 
            {
                if (a.Id == id)
                {
                    Marcacao marcacaoPrice = new Marcacao(id.ToString(), a.FreightValue.ToString(), date1, date2);
                    geralBooking.Add(marcacaoPrice);
                    cargosBooking.Add(marcacao);
                    UpdateGeralBookingFile();
                    UpdateCargoBookingFile();
                    return "CargoPlane";
                }
            }
            foreach (AeronaveParticular a in jets) //if the inputed plane is a jet 
            {
                if (a.Id == id)
                {
                    Marcacao marcacaoPrice = new Marcacao(id.ToString(), a.FreightValue.ToString(), date1, date2);
                    geralBooking.Add(marcacaoPrice);
                    jetsBooking.Add(marcacao);
                    UpdateGeralBookingFile();
                    UpdateJetsBookingFile();
                    return "JetPlane";
                }
            }
            foreach (Avioneta a in smallPlanes)//if the inputed plane is a Small Plane 
            {
                if (a.Id == id)
                {
                    Marcacao marcacaoPrice = new Marcacao(id.ToString(), a.FreightValue.ToString(), date1, date2);
                    geralBooking.Add(marcacaoPrice);
                    smallPlanesBooking.Add(marcacao);
                    UpdateGeralBookingFile();
                    UpdateSmallPlanesBookingFile();
                    return "SmallPlane";
                }
            }
            return "Not Found"; //if the plane doesn't exist returns not found
        }

        //Booking Geral

        public void ReadGeralBookingFile() //Reads the geral Booking File
        {
            StreamReader file = new StreamReader(@"freight.csv");

            string line;

            while ((line = file.ReadLine()) != null)
            {

                string[] fields = line.Split(';');

                int id;
                string model;
                string date1, date2;

                if (fields.Length == 4)
                {
                    Marcacao marcacao = new Marcacao(fields[0], fields[1], fields[2], fields[3]);

                    geralBooking.Add(marcacao);
                }

            }
            file.Close();
        }

        public void UpdateGeralBookingFile() //Updates the geral Booking File
        {
            StreamWriter file = new StreamWriter(@"freight.csv", true);

            foreach (Marcacao marcacao in geralBooking)
            {
                file.WriteLine(marcacao.Id + ";" + marcacao.Price + ";" + marcacao.StartDate + ";" + marcacao.EndDate);
            }
            file.Close();
        }

        //Manutencao

        public void ReadManutencaoFile() //Reads the Maintenance File
        {
            StreamReader file = new StreamReader(@"manutencoes.csv");

            string line;

            while ((line = file.ReadLine()) != null)

            {

                string[] fields = line.Split(';');

                int id;
                string model;
                string date1, date2;

                if (fields.Length == 3)
                {
                    Marcacao marcacao = new Marcacao(fields[0], fields[1], fields[2]);

                    ManutencoesBooking.Add(marcacao);
                }

            }

            file.Close();
        }

        public void UpdateManutencaoFile() //Updates the Maintenance File
        {
            StreamWriter file = new StreamWriter(@"manutencoes.csv", true);

            foreach (Marcacao marcacao in ManutencoesBooking)
            {
                file.WriteLine(marcacao.Id + ";" + marcacao.StartDate + ";" + marcacao.EndDate);
            }
            file.Close();
        }

        public string SearchIdManutencao(int id, string date1, string date2, DateTime datetime1, DateTime datetime2) //Registers the new maintenance
        {
            Marcacao marcacao = new Marcacao(id.ToString(), date1, date2);

            foreach (Aviao a in planes) //if the plane inputed is a Plane registers the maintenance
            {
                if (a.Id == id)
                {

                    ManutencoesBooking.Add(marcacao);
                    UpdateManutencaoFile();
                    return "Planes";
                }
            }
            foreach (AeronaveComercial a in comercial) //if the plane inputed is a Comercial registers the maintenance
            {
                if (a.Id == id)
                {
                    ManutencoesBooking.Add(marcacao);
                    UpdateManutencaoFile();
                    return "CommercialPlane";
                }
            }
            foreach (AeronaveMercadorias a in cargos) //if the plane inputed is a Cargo registers the maintenance
            {
                if (a.Id == id)
                {
                    ManutencoesBooking.Add(marcacao);
                    UpdateManutencaoFile();
                    return "CargoPlane";
                }
            }
            foreach (AeronaveParticular a in jets) //if the plane inputed is a Jet registers the maintenance
            {
                if (a.Id == id)
                {
                    ManutencoesBooking.Add(marcacao);
                    UpdateManutencaoFile();
                    return "JetPlane";
                }
            }
            foreach (Avioneta a in smallPlanes) //if the plane inputed is a Small Plane registers the maintenance
            {
                if (a.Id == id)
                {
                    ManutencoesBooking.Add(marcacao);
                    UpdateManutencaoFile();
                    return "SmallPlane";
                }
            }
            return "Not Found";
        }

        //Calcular Frete

        public double Search(int id, int numberOfDays) //calculates the price of a plane given the id
        {
            double value;

            foreach (AeronaveMercadorias plane in cargos) //searches for the id in the cargo list
            {
                if (plane.Id == id)
                {
                    return plane.FreightValue * numberOfDays; //multiplies the Daily Fright for the number of days
                }
            }
            foreach (AeronaveParticular plane in jets) //searches for the id in the Jets list
            {
                if (plane.Id == id)
                {
                    return plane.FreightValue * numberOfDays; //multiplies the Daily Fright for the number of days
                }
            }
            foreach (Avioneta plane in smallPlanes) //searches for the id in the small Planes list
            {
                if (plane.Id == id)
                {
                    return plane.FreightValue * numberOfDays; //multiplies the Daily Fright for the number of days
                }
            }
            return 0;
        }

        public string PlaneType(int id)
        {
            foreach (AeronaveMercadorias plane in cargos)
            {
                if (plane.Id == id)
                {
                    return "Cargo";
                }
            }
            foreach (AeronaveParticular plane in jets)
            {
                if (plane.Id == id)
                {
                    return "Jet";
                }
            }
            foreach (Avioneta avioneta in smallPlanes)
            {
                if (avioneta.Id == id)
                {
                    return "Small Plane";
                }
            }
            return "Not Found";
        }

        //Exercicio 5

        public string AdvanceOneDay(string date1) //Adds one day to the current Date
        {

            DateTime date;
            date = DateTime.Parse(date1);
            date = date.AddDays(1);
            return date.ToString("dd/MM/yyyy");


        }

        public void Verify(string date1) //Verifies if the planes are in Booking
        {
            changedToAvailableFromFreight.Clear();
            changedToAvailableFromMaintenance.Clear();


            DateTime dateinitial;
            DateTime datebook;

            DateTime.TryParse(date1, out dateinitial);

            foreach (Marcacao marca in geralBooking)
            {
                DateTime.TryParse(marca.StartDate, out datebook);

                if (datebook == dateinitial) //if the date is the same as the start date of the booking changes the state to booked
                {
                    ChangeAviaoState(int.Parse(marca.Id), "Booked");
                    ChangeAeronaveComercialState(int.Parse(marca.Id), "Booked");
                    ChangeAeronaveMercadoriasState(int.Parse(marca.Id), "Booked");
                    ChangeAeronaveParticularState(int.Parse(marca.Id), "Booked");
                    ChangeAvionetaState(int.Parse(marca.Id), "Booked");
                }
            }
        }

        public void VerifyAvailable(string date1) //Verifies if the planes are available from Booking
        {
            DateTime dateinitial;
            DateTime datebook;

            DateTime.TryParse(date1, out dateinitial);

            foreach (Marcacao marca in geralBooking)
            {
                DateTime.TryParse(marca.EndDate, out datebook);

                if (datebook == dateinitial) //if the date is the same as the end date of the booking changes the state to available
                {
                    changedToAvailableFromFreight.Add(marca.Id.ToString());
                    ChangeAviaoState(int.Parse(marca.Id), "Available");
                    ChangeAeronaveComercialState(int.Parse(marca.Id), "Available");
                    ChangeAeronaveMercadoriasState(int.Parse(marca.Id), "Available");
                    ChangeAeronaveParticularState(int.Parse(marca.Id), "Available");
                    ChangeAvionetaState(int.Parse(marca.Id), "Available");
                }
            }
        }

        public void VerifyManutencao(string date1) //Verifies if the planes are in Maintenance
        {
            DateTime dateinitial;
            DateTime datebook;

            DateTime.TryParse(date1, out dateinitial);

            foreach (Marcacao marca in ManutencoesBooking)
            {
                DateTime.TryParse(marca.StartDate, out datebook);

                if (datebook == dateinitial) //if the date is the same as the start date of the maintenance changes the state to maintenance
                {
                    ChangeAviaoState(int.Parse(marca.Id), "Maintenance");
                    ChangeAeronaveComercialState(int.Parse(marca.Id), "Maintenance");
                    ChangeAeronaveMercadoriasState(int.Parse(marca.Id), "Maintenance");
                    ChangeAeronaveParticularState(int.Parse(marca.Id), "Maintenance");
                    ChangeAvionetaState(int.Parse(marca.Id), "Maintenance");
                }
            }
        }

        public void VerifyAvailableFromManutencao(string date1) //Verifies if the planes are available from Maintenance
        {
            DateTime dateinitial;
            DateTime datebook;

            DateTime.TryParse(date1, out dateinitial);

            foreach (Marcacao marca in ManutencoesBooking)
            {
                DateTime.TryParse(marca.EndDate, out datebook);

                if (datebook == dateinitial) //if the date is the same as the end date of the maintenance changes the state to available
                {
                    changedToAvailableFromMaintenance.Add(marca.Id.ToString());
                    ChangeAviaoState(int.Parse(marca.Id), "Available");
                    ChangeAeronaveComercialState(int.Parse(marca.Id), "Available");
                    ChangeAeronaveMercadoriasState(int.Parse(marca.Id), "Available");
                    ChangeAeronaveParticularState(int.Parse(marca.Id), "Available");
                    ChangeAvionetaState(int.Parse(marca.Id), "Available");
                    UpdateDateMaintenance(int.Parse(marca.Id), datebook);
                }
            }
        }

        public string ShowsAvailableFromF() //Returns string with all the Available planes from Booking
        {

            string finaltext;
            finaltext = string.Join(";", changedToAvailableFromFreight);

            return finaltext;

        }

        public string ShowsAvailableFromM() //Returns string with all the Available planes from Maintenance
        {

            string finaltext;
            finaltext = string.Join(";", changedToAvailableFromMaintenance);

            return finaltext;
        }

        public void ChangeState(int id, string state) //Changes the State of a plane given a plane id
        {
            //searches for the planes
            foreach (AeronaveComercial aeronavecomercial in comercial)
            {
                //changes the state 
                if (aeronavecomercial.Id == id)
                {
                    aeronavecomercial.Activity = state;
                    UpdateAeronaveComercialFile(); //copies the list to the file
                    MessageBox.Show("Comercial Plane State Changed");
                }
            }

            //searches for the planes
            foreach (AeronaveMercadorias cargo in cargos)
            {
                //changes the state 
                if (cargo.Id == id)
                {
                    cargo.Activity = state;
                    UpdateAeronaveMercadoriasFile(); //copies the list to the file
                    MessageBox.Show("Cargo State Changed");
                    return;
                }
            }

            //searches for the planes
            foreach (AeronaveParticular jet in jets)
            {
                //changes the state 
                if (jet.Id == id)
                {
                    jet.Activity = state;
                    UpdateAeronaveParticularFile(); //copies the list to the file
                    MessageBox.Show("Jet State Changed");
                    return;
                }
            }

            //searches for the planes
            foreach (Aviao aviao in planes)
            {
                //changes the state 
                if (aviao.Id == id)
                {
                    aviao.Activity = state;
                    UpdateAviaoFile(); //copies the list to the file
                    MessageBox.Show("Plane State Changed");
                    return;
                }
            }

            //searches for the planes 
            foreach (Avioneta avioneta in smallPlanes)
            {
                //changes the state 
                if (avioneta.Id == id)
                {
                    avioneta.Activity = state;
                    UpdateAvionetaFile(); //copies the list to the file
                    MessageBox.Show("Small Plane State Changed");
                    return;
                }
            }

            MessageBox.Show("Plane not Found");
        }

        public void UpdateDateMaintenance(int id, DateTime date)  //Registers the Last Maintenance date given the plane id
        {
            //searches for the planes
            foreach (AeronaveComercial aeronavecomercial in comercial) //searches for the plane in the comercial list
            {
                //changes the state 
                if (aeronavecomercial.Id == id)
                {
                    aeronavecomercial.MaintenanceDate = date.ToString("dd-MM-yyyy");
                    UpdateAeronaveComercialFile(); //copies the list to the file
                    MessageBox.Show("Comercial Plane State Changed");
                }
            }

            //searches for the planes
            foreach (AeronaveMercadorias cargo in cargos) //searches for the plane in the cargos list
            {
                //changes the state 
                if (cargo.Id == id)
                {
                    cargo.MaintenanceDate = date.ToString("dd-MM-yyyy");
                    UpdateAeronaveMercadoriasFile(); //copies the list to the file
                    return;
                }
            }

            //searches for the planes
            foreach (AeronaveParticular jet in jets) //searches for the plane in the jets list
            {
                //changes the state 
                if (jet.Id == id)
                {
                    jet.MaintenanceDate = date.ToString("dd-MM-yyyy");
                    UpdateAeronaveParticularFile(); //copies the list to the file
                    return;
                }
            }

            //searches for the planes
            foreach (Aviao aviao in planes) //searches for the plane in the planes list
            {
                //changes the state 
                if (aviao.Id == id)
                {
                    aviao.MaintenanceDate = date.ToString("dd-MM-yyyy");
                    UpdateAviaoFile(); //copies the list to the file
                    return;
                }
            }

            //searches for the planes 
            foreach (Avioneta avioneta in smallPlanes) //searches for the plane in the Small Planes list
            {
                //changes the state 
                if (avioneta.Id == id)
                {
                    avioneta.MaintenanceDate = date.ToString("dd-MM-yyyy");
                    UpdateAvionetaFile(); //copies the list to the file
                    return;
                }
            }
        }

        public void ListsPlanes(DataGridView datagrid) //Lists every plane from the plane list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"planes.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string valores;
            string[] values;

                foreach (Aviao aviao in planes)
                {
                    valores = aviao.Id.ToString() + ";" + aviao.Model + "; " + aviao.Capacity.ToString() + ";" + aviao.Autonomy.ToString() + ";" + aviao.MaintenanceDate + ";" + aviao.Activity + ";" + aviao.EngineQuantity.ToString() + ";" + aviao.Brand + ";" + aviao.ManufacturingYear;
                    values = valores.Split(';');

                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table

                }            
            
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsComercials(DataGridView datagrid) //Lists every plane from the comercials list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"comercial.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Nº.Flights Per Day", "Company" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string valores;
            string[] values;

           
                foreach (AeronaveComercial comerciall in comercial)
                {
                    valores = comerciall.Id.ToString() + ";" + comerciall.Model + "; " + comerciall.Capacity.ToString() + ";" + comerciall.Autonomy.ToString() + ";" + comerciall.MaintenanceDate + ";" + comerciall.Activity + ";" + comerciall.EngineQuantity.ToString() + ";" + comerciall.Brand + ";" + comerciall.ManufacturingYear + ";"+comerciall.DailyFlightsNumber + ";" + comerciall.Airline;
                    values = valores.Split(';');

                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table

                }
            
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsCargos(DataGridView datagrid) //Lists every plane from the cargos list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"cargos.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Cargo capacity", "Freight rate" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string valores;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
                foreach (AeronaveMercadorias cargoo in cargos)
                {
                    valores = cargoo.Id.ToString() + ";" + cargoo.Model + "; " + cargoo.Capacity.ToString() + ";" + cargoo.Autonomy.ToString() + ";" + cargoo.MaintenanceDate + ";" + cargoo.Activity + ";" + cargoo.EngineQuantity.ToString() + ";" + cargoo.Brand + ";" + cargoo.ManufacturingYear + ";" + cargoo.CargoCapacity + ";" + cargoo.FreightValue;
                    values = valores.Split(';');

                    DataRow dr = dt.NewRow(); //creates a new row

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table

                }
            
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsJets(DataGridView datagrid) //Lists every plane from the jet list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"jets.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Nº. Owners", "Freight rate" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string valores;
            string[] values;

                foreach (AeronaveParticular jett in jets)
                {
                    valores = jett.Id.ToString() + ";" + jett.Model + "; " + jett.Capacity.ToString() + ";" + jett.Autonomy.ToString() + ";" + jett.MaintenanceDate + ";" + jett.Activity + ";" + jett.EngineQuantity.ToString() + ";" + jett.Brand +  ";" + jett.ManufacturingYear + ";" + jett.OwnersNumber + ";" + jett.FreightValue;
                    values = valores.Split(';');

                    DataRow dr = dt.NewRow(); //creates a new row

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table

                }
            
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsSmallPlanes(DataGridView datagrid) //Lists every plane from the small Planes list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"smallPlanes.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Minimum Takeoff Area", "Minimum Landing Area", "Freight" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string valores;
            string[] values;

            foreach (Avioneta splanee in smallPlanes)
            {
                valores = splanee.Id.ToString() + ";" + splanee.Model + "; " + splanee.Capacity.ToString() + ";" + splanee.Autonomy.ToString() + ";" + splanee.MaintenanceDate + ";" + splanee.Activity + ";" + splanee.EngineQuantity.ToString() + ";" + splanee.Brand + ";" + splanee.ManufacturingYear + ";" + splanee.MinimumLandingArea + ";" + splanee.FreightValue;
                values = valores.Split(';');

                DataRow dr = dt.NewRow();

                for (int i = 0; i < values.Length; i++) //adds the values to the new row
                {
                    dr[i] = values[i];
                }

                dt.Rows.Add(dr); //adds the row to the table

            }
            
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }


        public void ListsBooking(DataGridView datagrid) //Lists the booking list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Plane ID", "Daily Price", "Start Date", "End Date" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string valores;
            string[] values;

            foreach (Marcacao apointment in geralBooking)
            {
                if (apointment.Id.ToString() != "")
                {
                    valores = apointment.Id.ToString() + ";" + apointment.Price + "; " + apointment.StartDate + ";" + apointment.EndDate;
                    values = valores.Split(';');

                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }
                    dt.Rows.Add(dr); //adds the row to the table
                }

               

            }
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }


        public void ListsMaintenance(DataGridView datagrid) //Lists the maintenance list in the DataGrid
        {
            // Limpa a DataGridView
            datagrid.DataSource = null;
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Plane ID", "Start Date", "End Date" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string valores;
            string[] values;

            foreach (Marcacao apointment in ManutencoesBooking)
            {
                if (apointment.Id.ToString() != "")
                {
                    valores = apointment.Id.ToString() + "; " + apointment.StartDate + ";" + apointment.EndDate;
                    values = valores.Split(';');

                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table
                }

            }
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        //Lists Available Planes

        public void ListsAvailablePlanes(DataGridView datagrid) //Lists the Available Planes list from the plane list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"planes.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string valores;
            string[] values;

 
                foreach (Aviao aviao in planes)
                {
                    if (aviao.Activity == "Available") //if the plane is available
                    {

                        valores = aviao.Id.ToString() + ";" + aviao.Model + "; " + aviao.Capacity.ToString() + ";" + aviao.Autonomy.ToString() + ";" + aviao.MaintenanceDate + ";" + aviao.Activity + ";" + aviao.EngineQuantity.ToString() + ";" + aviao.Brand + ";" + aviao.ManufacturingYear;
                        values = valores.Split(';');

                        DataRow dr = dt.NewRow(); 

                        for (int i = 0; i < values.Length; i++) //adds the values to the new row
                        {
                            dr[i] = values[i];
                        }

                        dt.Rows.Add(dr); //adds the row to the table


                    }
                    
                }
            
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsAvailableComercials(DataGridView datagrid) //Lists the Available Comercials list from the comercial list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"comercial.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Nº.Flights Per Day", "Company" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;
            string valores;

            foreach (AeronaveComercial comerciall in comercial)
            {
                valores = comerciall.Id.ToString() + ";" + comerciall.Model + "; " + comerciall.Capacity.ToString() + ";" + comerciall.Autonomy.ToString() + ";" + comerciall.MaintenanceDate + ";" + comerciall.Activity + ";" + comerciall.EngineQuantity.ToString() + ";" + comerciall.Brand + ";" + comerciall.ManufacturingYear + ";" + comerciall.DailyFlightsNumber + ";" + comerciall.Airline;
                values = valores.Split(';');

                if(comerciall.Activity == "Available")
                {
                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table
                }

            }
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsAvailableCargos(DataGridView datagrid) //Lists the Available Cargo Planes list from the cargo planes list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"cargos.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Cargo capacity", "Freight rate" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;
            string valores;

            //Adds the lines to the Table and Uodates the Task List
            foreach (AeronaveMercadorias cargoo in cargos)
            {
                valores = cargoo.Id.ToString() + ";" + cargoo.Model + "; " + cargoo.Capacity.ToString() + ";" + cargoo.Autonomy.ToString() + ";" + cargoo.MaintenanceDate + ";" + cargoo.Activity + ";" + cargoo.EngineQuantity.ToString() + ";" + cargoo.Brand + ";" + cargoo.ManufacturingYear + ";" + cargoo.CargoCapacity + ";" + cargoo.FreightValue;
                values = valores.Split(';');

                if(cargoo.Activity == "Available")
                {
                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table
                }          

            }

            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsAvailableJets(DataGridView datagrid) //Lists the Available Jets list from the jets list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"jets.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Nº.Owners", "Freight rate" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;
            string valores;

            foreach (AeronaveParticular jett in jets)
            {
                valores = jett.Id.ToString() + ";" + jett.Model + "; " + jett.Capacity.ToString() + ";" + jett.Autonomy.ToString() + ";" + jett.MaintenanceDate + ";" + jett.Activity + ";" + jett.EngineQuantity.ToString() + ";" + jett.Brand + ";" + jett.ManufacturingYear + ";" + jett.OwnersNumber + ";" + jett.FreightValue;
                values = valores.Split(';');

                if(jett.Activity == "Available")
                {
                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table
                }

              

            }

            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsAvailableSmallPlanes(DataGridView datagrid) //Lists the Available Small Planes list from the small Plane list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"smallPlanes.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Minimum Takeoff Area", "Minimum Landing Area" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;
            string valores;

            foreach (Avioneta splanee in smallPlanes)
            {
                valores = splanee.Id.ToString() + ";" + splanee.Model + "; " + splanee.Capacity.ToString() + ";" + splanee.Autonomy.ToString() + ";" + splanee.MaintenanceDate + ";" + splanee.Activity + ";" + splanee.EngineQuantity.ToString() + ";" + splanee.Brand + ";" + splanee.ManufacturingYear + ";" + splanee.MinimumLandingArea + ";" + splanee.FreightValue;
                values = valores.Split(';');

                if(splanee.Activity == "Available")
                {
                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table
                }
                

            }
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsMaintenancePlanes(DataGridView datagrid) //Lists the Maintenance Planes list from the plane list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"planes.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;
            string valores;

            foreach (Aviao aviao in planes)
            {
                if (aviao.Activity == "Maintenance")
                {

                    valores = aviao.Id.ToString() + ";" + aviao.Model + "; " + aviao.Capacity.ToString() + ";" + aviao.Autonomy.ToString() + ";" + aviao.MaintenanceDate + ";" + aviao.Activity + ";" + aviao.EngineQuantity.ToString() + ";" + aviao.Brand + ";" + aviao.ManufacturingYear;
                    values = valores.Split(';');

                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table


                }

            }
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsMaintenanceComercials(DataGridView datagrid) //Lists the Maintenance Comercials list from the plane list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"comercial.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Nº.Flights Per Day", "Company" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            string valores;

            foreach (AeronaveComercial comerciall in comercial)
            {
                valores = comerciall.Id.ToString() + ";" + comerciall.Model + "; " + comerciall.Capacity.ToString() + ";" + comerciall.Autonomy.ToString() + ";" + comerciall.MaintenanceDate + ";" + comerciall.Activity + ";" + comerciall.EngineQuantity.ToString() + ";" + comerciall.Brand + ";" + comerciall.ManufacturingYear + ";" + comerciall.DailyFlightsNumber + ";" + comerciall.Airline;
                values = valores.Split(';');

                if (comerciall.Activity == "Maintenance")
                {
                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row                 
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table
                }



            }
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsMaintenanceCargos(DataGridView datagrid) //Lists the Maintenance Cargos list from the cargo list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"cargos.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Cargo capacity", "Freight rate" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            string valores;

            //Adds the lines to the Table and Uodates the Task List
            foreach (AeronaveMercadorias cargoo in cargos)
            {
                valores = cargoo.Id.ToString() + ";" + cargoo.Model + "; " + cargoo.Capacity.ToString() + ";" + cargoo.Autonomy.ToString() + ";" + cargoo.MaintenanceDate + ";" + cargoo.Activity + ";" + cargoo.EngineQuantity.ToString() + ";" + cargoo.Brand + ";" + cargoo.ManufacturingYear + ";" + cargoo.CargoCapacity + ";" + cargoo.FreightValue;
                values = valores.Split(';');

                if (cargoo.Activity == "Maintenance")
                {
                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table
                }



            }
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsMaintenanceJets(DataGridView datagrid) //Lists the Maintenance Jets list from the jets list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"jets.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Nº.Owners", "Freight rate" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            string valores;

            foreach (AeronaveParticular jett in jets)
            {
                valores = jett.Id.ToString() + ";" + jett.Model + "; " + jett.Capacity.ToString() + ";" + jett.Autonomy.ToString() + ";" + jett.MaintenanceDate + ";" + jett.Activity + ";" + jett.EngineQuantity.ToString() + ";" + jett.Brand + ";" + jett.ManufacturingYear + ";" + jett.OwnersNumber + ";" + jett.FreightValue;
                values = valores.Split(';');

                if (jett.Activity == "Maintenance") //if the plane is in maintenance
                {
                    DataRow dr = dt.NewRow(); //creates a new row

                    
                    for (int i = 0; i < values.Length; i++) //adds the values to the new row
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr); //adds the row to the table
                }



            }
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }

        public void ListsMaintenanceSmallPlanes(DataGridView datagrid) //Lists the Maintenance Small Planes list from the small planes list in the DataGrid
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"smallPlanes.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "Status", "Nº.Motors", "Brand", "Production Year", "Minimum Takeoff Area", "Minimum Landing Area" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            string valores;

            foreach (Avioneta splanee in smallPlanes)
            {
                valores = splanee.Id.ToString() + ";" + splanee.Model + "; " + splanee.Capacity.ToString() + ";" + splanee.Autonomy.ToString() + ";" + splanee.MaintenanceDate + ";" + splanee.Activity + ";" + splanee.EngineQuantity.ToString() + ";" + splanee.Brand + ";" + splanee.ManufacturingYear + ";" + splanee.MinimumLandingArea + ";" + splanee.FreightValue;
                values = valores.Split(';');

                if (splanee.Activity == "Maintenance")
                {
                    DataRow dr = dt.NewRow();

                    // Adiciona os valores à linha
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }

                    // Adiciona a linha ao DataTable
                    dt.Rows.Add(dr);
                }


            }
            file.Close();
            datagrid.DataSource = dt;
            datagrid.RowHeadersVisible = false;
        }


        public bool VerifiesDates(DateTime dt1, DateTime dt2) //verifies if the first date is greater than the second
        {
            if (dt1 > dt2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string profit(DateTime start, DateTime end)
        {
            // Calculate total value within date range
            double totalvalue = 0;
            DateTime currentDate = start;

            while (currentDate <= end)
            {
                foreach (Marcacao marc in geralBooking)
                {
                    DateTime reservaInicial, reservaFinal;
                    if (!DateTime.TryParse(marc.StartDate, out reservaInicial) ||
                        !DateTime.TryParse(marc.EndDate, out reservaFinal))
                    {
                        // Handle invalid date format
                        continue;
                    }

                    // Adjust comparison to include both start and end dates
                    if (currentDate >= reservaInicial && currentDate <= reservaFinal)
                    {
                        if (double.TryParse(marc.Price, out double price))
                        {
                            totalvalue += price;
                        }
                    }
                }
                currentDate = currentDate.AddDays(1);
            }

            return totalvalue.ToString();
        }

        //Remove Plane

        public bool removePlane(string id)
        {
            int inputedID = int.Parse(id);

            foreach (AeronaveComercial comercialPlane in comercial)
            {
                if(comercialPlane.Id == inputedID)
                {
                    comercial.Remove(comercialPlane);
                    UpdateAeronaveComercialFile();
                    return true;
                }
            }

            foreach (AeronaveMercadorias cargoPlane in cargos)
            {
                if (cargoPlane.Id == inputedID)
                {
                    cargos.Remove(cargoPlane);
                    UpdateAeronaveMercadoriasFile();
                    return true;
                }
            }

            foreach (AeronaveParticular jetPlane in jets)
            {
                if (jetPlane.Id == inputedID)
                {
                    jets.Remove(jetPlane);
                    UpdateAeronaveParticularFile();
                    return true;
                }
            }

            foreach (Aviao plane in planes)
            {
                if (plane.Id == inputedID)
                {
                    planes.Remove(plane);
                    UpdateAviaoFile();
                    return true;
                }
            }

            foreach (Avioneta smallPlane in smallPlanes)
            {
                if (smallPlane.Id == inputedID)
                {
                    smallPlanes.Remove(smallPlane);
                    UpdateAvionetaFile();
                    return true;
                }
            }

            return false;
        }

        public bool ContainsLetters(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsNumbers(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
