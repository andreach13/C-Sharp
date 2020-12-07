using System.Collections.Generic;
using System;

public class ReinoAnimal
{
    public List<Mamiferos> ListadeMamiferos { get; set; }
    public List<Peces> ListadePeces { get; set; }
    public List<Anfibios> ListadeAnfibios { get; set; }
    public List<Aves> ListadeAves { get; set; }
    public List<Reptiles> ListadeReptiles { get; set; }

    public ReinoAnimal()
    {
        ListadeAves = new List<Aves>();
        cargarAves();

        ListadeAnfibios = new List<Anfibios>();
        cargarAnfibios();

        ListadeMamiferos = new List<Mamiferos>();
        cargarMamiferos();

        ListadePeces = new List<Peces>();
        cargarPeces();

        ListadeReptiles = new List<Reptiles>();
        cargarReptiles();

    }

    private void cargarAves()
        {
            Aves aguila = new Aves("Aguila", "Ave", "Accipitridae","Bosques de coniferas, praderas, tundras, llanuras, etc", "Carnivoro", "Oviparos", "pardo con manchas blancas en las alas y en la base de la cola y nuca color dorado" );
            ListadeAves.Add(aguila);

            Aves gallina = new Aves("Gallina","Ave", "Phasianidae", "Terrestre", "Omnivoro", "Oviparos","Tonos cafes, blancos o grises");
            ListadeAves.Add(gallina);
            
            Aves loro = new Aves("Loro", "Ave", "Psitasiformes", "Areas tropicales con temperaturas cálidas", "Omnivoros", "Oviparos", "Hay especies que son muy coloridas");
            ListadeAves.Add(loro);
        }

    public void Aguila()    
    {
        Aves aguilar = ListadeAves.Find(p => p.Nombre == "Aguila");
        Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Nombre:          " +          aguilar.Nombre);
            Console.WriteLine("Especie:         " +         aguilar.Especie);
            Console.WriteLine("Familia:         " +         aguilar.Familia );
            Console.WriteLine("Habitat:         " +         aguilar.Habitat);
            Console.WriteLine("Plumaje:         " +         aguilar.Plumaje);
            Console.WriteLine("Alimentacion:    " +     aguilar.Alimentacion );
            Console.WriteLine("Reproduccion:    "+     aguilar.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            aguilar.Datos("El águila real es un ave de gran tamaño. Las patas de las águilas son muy fuertes y sus uñas son fuertes  y afiladas. La hembra es más grande que el macho, ya que puede medir hasta 95 cm de largo y llegar a alcanzar hasta los 5 Kg. de peso, mientras el macho puede medir 87 cm. de largo y alcanza un peso de 3 Kg. como máximo.");
            Console.WriteLine("");
            Console.WriteLine("El sonido caracteristico de este animal es como un chillido ");
            Console.Write("Puede volar?: ");
            aguilar.Volar(true);
            
        Console.ReadLine();
    }

    public void Gallina()    
    {
        Aves gallina = ListadeAves.Find(p => p.Nombre == "Gallina");
        Console.Clear();    
            Console.WriteLine("Nombre:          " +    gallina.Nombre);
            Console.WriteLine("Especie:         " +   gallina.Especie);
            Console.WriteLine("Familia:         " +   gallina.Familia );
            Console.WriteLine("Habitat:         " +    gallina.Habitat);
            Console.WriteLine("Plumaje:         " +    gallina.Plumaje);
            Console.WriteLine("Alimentacion:    " + gallina.Alimentacion );
            Console.WriteLine("Reproduccion:    " +     gallina.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            gallina.Datos("Caracterizadas por su pico corto y algo curvado, sus alas también cortas y sus patas robustas.Tanto el gallo como la gallina son aves criadas principalmente para el consumo de los seres humanos, ya que su carne y huevos forman parte de la dieta de la mayoría de las personas que no son vegetarianos, ni veganos.");
            Console.WriteLine("");
            Console.WriteLine("El sonido caracteristico de este animal es un cacareo");
            Console.Write("Puede volar?: ");
            gallina.Volar(false);
            
        Console.ReadLine();
    }

    public void Loro()    
    {
        Aves loro = ListadeAves.Find(p => p.Nombre == "Loro");
        Console.Clear();
            Console.WriteLine("Nombre:          " +    loro.Nombre);
            Console.WriteLine("Especie:         " +   loro.Especie);
            Console.WriteLine("Familia:         " +   loro.Familia );
            Console.WriteLine("Habitat:         " +    loro.Habitat);
            Console.WriteLine("Plumaje:         " +    loro.Plumaje);
            Console.WriteLine("Alimentacion:    " + loro.Alimentacion );
            Console.WriteLine("Reproduccion:    " +     loro.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            loro.Datos("Se caracterizan por tener un pico corto, muy fuerte, con la mandíbula superior móvil para permitirle trepar. Su lengua es carnosa y gruesa y en algunas especies están cubiertas de papilas fibrosas.Las patas de los loros son atípicas. Se trata de animales sociables y gregarios");
            Console.WriteLine("");
            Console.WriteLine("Tienen la capacidad para hablar. Pueden ser grandes imitadores de la voz humana");
            Console.Write("Puede volar?: ");
            loro.Volar(false);
            
        Console.ReadLine();
    }
    
    private void cargarAnfibios()
        {
            Anfibios salamandra = new Anfibios("Salamandra", "Anfibio", "Salamandridae", "Terrestre", "Carnivoro", "Ovoviviparo", 4);
            ListadeAnfibios.Add(salamandra);
            
            Anfibios sapo = new Anfibios("Sapo", "Anfibio", "Bufonidae", "Embalses, ríos y arroyos, bosques de coniferas, etc ", "Carnivoros", "Oviparo",4 );
            ListadeAnfibios.Add(sapo);

            Anfibios triton = new Anfibios("Triton", "Anfibio", "Salamandridae", "Acuatico/Terrestre: lagunas, arroyos-pantanos y bosques", "Carnivoro", "Ovoviviparo",4);
            ListadeAnfibios.Add(triton);
        }

    public void Salamandra()    
    {
        Anfibios salamandra = ListadeAnfibios.Find(p => p.Nombre == "Salamandra");
        Console.Clear();
            Console.WriteLine("Nombre:          " +    salamandra.Nombre);
            Console.WriteLine("Especie:         " +   salamandra.Especie);
            Console.WriteLine("Familia:         " +   salamandra.Familia );
            Console.WriteLine("Habitat:         " +    salamandra.Habitat);
            Console.WriteLine("Alimentacion:    " + salamandra.Alimentacion );
            Console.WriteLine("Reproduccion:    " +     salamandra.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            salamandra.Datos("Contraste de colores negro y amarillo, a veces rojizo, muy llamativo. Posee unas glándulas en el cuello que segregan una sustancia tóxica, que irrita la mucosa de sus depredadores. Su cola es redondeada, al igual que sus dedos y su corto hocico. Aunque es un anfibio, es principalmente terrestre y sólo se acerca al agua para criar");
            Console.WriteLine(""); 
            Console.Write("Es considerado un animal toxico?: "); 
            salamandra.Toxixidad(true);
            
        Console.ReadLine();
    }

    public void Sapo()    
    {
        Anfibios sapo = ListadeAnfibios.Find(p => p.Nombre == "Sapo");
        Console.Clear();
            Console.WriteLine("Nombre:          " +    sapo.Nombre);
            Console.WriteLine("Especie:         " +   sapo.Especie);
            Console.WriteLine("Familia:         " +   sapo.Familia );
            Console.WriteLine("Habitat:         " +    sapo.Habitat);
            Console.WriteLine("Alimentacion:    " + sapo.Alimentacion );
            Console.WriteLine("Reproduccion:    " +     sapo.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            sapo.Datos("Carecen de cola. Extremidades cortas y robustas. Su aspecto general es el de un animal robusto, con una cabeza no muy grande en relación al tamaño del cuerpo, algo aplastada, ancha y con un desarrollado arco supraciliar o ceja. El hocico es corto y redondeado ");
            Console.WriteLine(""); 
            Console.Write("Es considerado un animal toxico?: "); 
            sapo.Toxixidad(true);
            
        Console.ReadLine();
    }

    public void Triton()    
    {
        Anfibios triton = ListadeAnfibios.Find(p => p.Nombre == "Triton");
        Console.Clear();
            Console.WriteLine("Nombre:          " +    triton.Nombre);
            Console.WriteLine("Especie:         " +   triton.Especie);
            Console.WriteLine("Familia:         " +   triton.Familia );
            Console.WriteLine("Habitat:         " +    triton.Habitat);
            Console.WriteLine("Alimentacion:    " + triton.Alimentacion );
            Console.WriteLine("Reproduccion:    " +     triton.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            triton.Datos("");
            Console.WriteLine("Estos anfibios tienen un cuerpo largo y delgado, patas cortas, sin membranas interdigitales y una cola bien desarrollada y aplanada lateralmente. En general, los tritones son más pequeños que las salamandras y la mayor parte de su vida están en el agua.Presentan una cintura pélvica, en su mayor parte cartilaginosa, careciendo de una cintura escapular dérmica. A diferencia de las ranas, los tritones no tienen oído medio."); 
            Console.Write("Es considerado un animal toxico?: "); 
            triton.Toxixidad(true);
            
        Console.ReadLine();
    }


    private void cargarPeces()
        {
            Peces pirania = new Peces("Piraña", "Peces", "Serrasalmidae","Ríos de aguas templado-cálidas y cálidas de Sudamérica","Carnivoros, aunque algunas especies son omnivoros","Oviparos", "La piel suele ser plateada, y color rojo, naranja o amarillo en la zona ventral y debajo de la cabeza. " );
            ListadePeces.Add(pirania);

            Peces atun = new Peces("Atun", "Peces", "Escombridos", "Aguas costeras y pelagicas", "Carnivoro","Oviparo","Azul oscuro por el dorso yplateado por el vientre");
            ListadePeces.Add(atun);

            Peces barracuda = new Peces("Barracuda", "Peces", "Esfirenidos", "Region tropical de la zona Indo-Pacifica y Oceano Atlantico", "Carnivoro", "Oviparo","Color plateado, surcado con lineas laterales pardas");
            ListadePeces.Add(barracuda);
        }
    
    public void Piraña()    
    {
        Peces pirania = ListadePeces.Find(p => p.Nombre == "Piraña");
        Console.Clear();
            Console.WriteLine("Nombre:          " +    pirania.Nombre);
            Console.WriteLine("Especie:         " +   pirania.Especie);
            Console.WriteLine("Familia:         " +   pirania.Familia );
            Console.WriteLine("Habitat:         " +    pirania.Habitat);
            Console.WriteLine("Escamas:         " +    pirania.Escamas);
            Console.WriteLine("Alimentacion:    " + pirania.Alimentacion );
            Console.WriteLine("Reproduccion:    " +     pirania.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            pirania.Datos("Las pirañas solamente se encuentran en las aguas dulces de Centro y Sudamérica. El Amazonas es el lugar donde hay la mayor concentración de esta especie de peces. Aquí conviven multitud de tipos de piraña, ya que es una zona con una diversidad biológica exquisita. El cuerpo de la mayoría de las pirañas es robusto y estrecho. Miden de 14 a 26 centímetros de longitud pero hay especies que crecen hasta alcanzar más de 40 centímetros. La cabeza es prominente y las mandíbulas tienen gran fuerza, con una sola fila de dientes en cada una. Dichos dientes triangulares y puntiagudos son sumamente filosos como cuchillas y la piraña los utiliza para punción y cizallamiento.");
            Console.WriteLine("");            
            
        Console.ReadLine();
    }

    public void Atun()    
    {
        Peces atun = ListadePeces.Find(p => p.Nombre == "Atun");
        Console.Clear();
            Console.WriteLine("Nombre:          " +    atun.Nombre);
            Console.WriteLine("Especie:         " +   atun.Especie);
            Console.WriteLine("Familia:         " +   atun.Familia );
            Console.WriteLine("Habitat:         " +    atun.Habitat);
            Console.WriteLine("Escamas:         " +    atun.Escamas);
            Console.WriteLine("Alimentacion:    " +     atun.Alimentacion );
            Console.WriteLine("Reproduccion:    " +     atun.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            atun.Datos("El atún destaca por ser uno de los más capturados y consumidos, debido a su preciada carne y versatilidad. Al tratarse de un ejemplar que alcanza gran tamaño, resulta muy rendidor si hay muchos comensales. La carne del atún posee cifras cercanas al 12% de grasa rica en ácidos omega-3 que ayudan a rebajar los niveles de colesterol y triglicéridos de la sangre, disminuyendo el riesgo de dolencias como la aterosclerosis, trombosis, así como la prevención de enfermedades cardiacas.");
            Console.WriteLine("");            
            
        Console.ReadLine();
    }

    public void Barracuda()    
    {
        Peces barracuda = ListadePeces.Find(p => p.Nombre == "Barracuda");
        Console.Clear();
            Console.WriteLine("Nombre:          " +    barracuda.Nombre);
            Console.WriteLine("Especie:         " +   barracuda.Especie);
            Console.WriteLine("Familia:         " +   barracuda.Familia );
            Console.WriteLine("Habitat:         " +    barracuda.Habitat);
            Console.WriteLine("Escamas:         " +    barracuda.Escamas);
            Console.WriteLine("Alimentacion:    " +     barracuda.Alimentacion );
            Console.WriteLine("Reproduccion:    " +     barracuda.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            barracuda.Datos("Esta especie se es conocida también por el nombre de barracuda gigante debido a su gran tamaño. Es un pez capaz de depredar a otras especies con gran ferocidad y velocidad. Utilizan la sorpresa como un arma. Se trata de una especie bastante oportunista que aprovecha algunos momentos más débiles para hacer su aparición en escena.");
            Console.WriteLine("");            
            
        Console.ReadLine();
    }

    
    private void cargarMamiferos()
        {
            Mamiferos perro = new Mamiferos("Perro","Mamifero","Canidos","Terrestre","Carnivoros", "Domestico", "Viviparo", 4);
            ListadeMamiferos.Add(perro);
    
            Mamiferos gato = new Mamiferos("Gato","Mamifero","Felidos","Terrestre","Carnivoros", "Domestico", "Viviparo", 4);
            ListadeMamiferos.Add(gato);

            Mamiferos vaca = new Mamiferos("Vaca","Mamifero", "Cavicornios", "Terrestre", "Hervivoro", "Domestico", "Viviparo", 4);
            ListadeMamiferos.Add(vaca);

            Mamiferos ballena = new Mamiferos("Ballena","Mamifero", "Cetaceos", "Acuaticos", "Carnivoros", "Salvaje", "Viviparo", 0);
            ListadeMamiferos.Add(ballena);
        }

    public void Perro()
    {
        Mamiferos perro = ListadeMamiferos.Find(p => p.Nombre == "Perro");
        
            Console.Clear();
            Console.WriteLine("Nombre:          " +    perro.Nombre);
            Console.WriteLine("Especie:         " +   perro.Especie);
            Console.WriteLine("Familia:         " +   perro.Familia );
            Console.WriteLine("Habitat:         " +    perro.Habitat);
            Console.WriteLine("Tipo animal:     " +    perro.Tipo);
            Console.WriteLine("Alimentacion:    " + perro.Alimentacion );
            Console.WriteLine("Reproduccion:    " +     perro.Reproduccion);
            Console.WriteLine("No. de Patas:    " +     perro.Patas);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            perro.Datos("Existen más de 800 razas de perro, con lo cual superan a cualquier otra especie. Cada especie presenta significativas diferencias en todas sus características, desde el pelaje y el tamaño hasta el comportamiento y la longevidad");
            Console.WriteLine("");
            Console.WriteLine("El sonido caracteristico de este animal es el ladrido:  ");
            perro.Sonidos("guao guao guao");

        Console.ReadLine();
    }

    public void Gato()
    {
        Mamiferos gato = ListadeMamiferos.Find(p => p.Nombre == "Gato");
            Console.Clear();
            Console.WriteLine("Nombre:          " +    gato.Nombre);
            Console.WriteLine("Especie:         " +   gato.Especie);
            Console.WriteLine("Familia:         " +   gato.Familia );
            Console.WriteLine("Habitat:         " +    gato.Habitat);
            Console.WriteLine("Tipo de Animal:  " +    gato.Tipo);
            Console.WriteLine("Alimentacion:    " + gato.Alimentacion );
            Console.WriteLine("Reproduccion:    " +     gato.Reproduccion);
            Console.WriteLine("No. de Patas:    " +     gato.Patas);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            gato.Datos("Tienen una gran destreza, gracias a la flexibilidad de sus patas, la utilización de su cola y su “reflejo de enderezamiento” que les permite girar su cuerpo en el aire cuando caen y así caer siempre sobre sus patas, que por su extraordinaria flexibilidad resisten caídas de alturas importantes.");
            Console.WriteLine("");
            Console.WriteLine("El sonido caracteristico de este animal es el maullido:  ");
            gato.Sonidos("miau miau miau");
        Console.ReadLine();
    }

    public void Vaca()
    {
        Mamiferos vaca = ListadeMamiferos.Find(p => p.Nombre == "Vaca");
            Console.Clear();
            Console.WriteLine("Nombre:          " +    vaca.Nombre);
            Console.WriteLine("Especie:         " +   vaca.Especie);
            Console.WriteLine("Familia:         " +   vaca.Familia );
            Console.WriteLine("Habitat:         " +    vaca.Habitat);
            Console.WriteLine("Tipo de Animal:  " +    vaca.Tipo);
            Console.WriteLine("Alimentacion:    " + vaca.Alimentacion );
            Console.WriteLine("Reproduccion:    "+     vaca.Reproduccion);
            Console.WriteLine("No. de Patas:    "+     vaca.Patas);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            vaca.Datos("Es un mamifero grande y pesado puede llegar a pesar hasta 1000 kg. El pelo de este mamifero es corto y no es espeso. La cola de este rumiante es bastante larga, adornada en s extremo por un mecho de pelos");
            Console.WriteLine("");
            Console.WriteLine("El sonido caracteristico de este animal es el mugido:  ");
            vaca.Sonidos("muuuuuuu");
        Console.ReadLine();
    }

    public void Ballena()
    {
        Mamiferos ballena = ListadeMamiferos.Find(p => p.Nombre == "Ballena");
        
        
            Console.Clear();
            Console.WriteLine("Nombre:        " +    ballena.Nombre);
            Console.WriteLine("Especie:       " +   ballena.Especie);
            Console.WriteLine("Familia:       " +   ballena.Familia );
            Console.WriteLine("Habitat:       " +    ballena.Habitat);
            Console.WriteLine("Tipo animal:   " +    ballena.Tipo);
            Console.WriteLine("Alimentacion:  " + ballena.Alimentacion );
            Console.WriteLine("Reproduccion:  " +     ballena.Reproduccion);
            Console.WriteLine("No. de Patas:  " +     ballena.Patas);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            ballena.Datos("No poseen patas, sino mas bien aletas y cuerpos como los de un pez. Es un cetáceo, es decir un mamífero adaptado a la vida acuática. A diferencia de los peces, los cetáceos tienen respiración pulmonar. Tienen un cuerpo similar al de los peces, porque ambos tienen formas hidrodinámicas.");
            Console.WriteLine("");
            Console.WriteLine("El sonido caracteristico de este animal es como un gemido/canto o silbido");

        Console.ReadLine();
    }
    
    private void cargarReptiles()
    {
        Reptiles anaconda = new Reptiles("Anaconda", "Reptil","Boidos", "Selvas, rios, lagos, estanques","Carnivoro","Viviparo","6 mts");
        ListadeReptiles.Add(anaconda);

        Reptiles dragon = new Reptiles("Dragon de Komodo", "Reptil","Varanidos", "Bosques, Llanuras, sabana,zonas rocosas secas","Carnivoro","Oviparo","3 mts");
        ListadeReptiles.Add(dragon);

        Reptiles camaleon = new Reptiles("Camaleon", "Reptil","Chamaeleonidae", "Dunas cercanas a la costa y matorrales","Carnivoro","Ovipara","25-30 cm");
        ListadeReptiles.Add(camaleon);
    }

    public void Anaconda()
    {
        Reptiles anaconda = ListadeReptiles.Find(p => p.Nombre == "Anaconda");
        
            Console.Clear();
            Console.WriteLine("Nombre:        " +    anaconda.Nombre);
            Console.WriteLine("Especie:       " +   anaconda.Especie);
            Console.WriteLine("Familia:       " +   anaconda.Familia );
            Console.WriteLine("Habitat:       " +    anaconda.Habitat);
            Console.WriteLine("Longitud:      " +    anaconda.Longitud);
            Console.WriteLine("Alimentacion:  " + anaconda.Alimentacion );
            Console.WriteLine("Reproduccion:  " +     anaconda.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            anaconda.Datos("Son serpientes no venenosas. Como el resto de animales ofidios, las anacondas son poiquilotermos, es quiere decir que no regulan la temperatura interna de su cuerpo. Ésta es la principal diferencia que tienen con las aves y los mamíferos, ya que éstos sí pueden regular su temperatura corporal, y de hecho, son llamados animales de “sangre caliente”.");
            

        Console.ReadLine();
    }

    public void Dragon()
    {
        Reptiles dragon = ListadeReptiles.Find(p => p.Nombre == "Dragon de Komodo");
        
            Console.Clear();
            Console.WriteLine("Nombre:        " +    dragon.Nombre);
            Console.WriteLine("Especie:       " +   dragon.Especie);
            Console.WriteLine("Familia:       " +   dragon.Familia );
            Console.WriteLine("Habitat:       " +    dragon.Habitat);
            Console.WriteLine("Longitud:      " +    dragon.Longitud);
            Console.WriteLine("Alimentacion:  " + dragon.Alimentacion );
            Console.WriteLine("Reproduccion:  " +     dragon.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            dragon.Datos("Posee un tamaño inusual y espectacular: es su principal característica. . Es el lagarto de mayor tamaño del mundo, con una longitud media de dos a tres metros y un peso de unos 70 kg.");
    

        Console.ReadLine();
    }

    public void Camaleon()
    {
        Reptiles camaleon = ListadeReptiles.Find(p => p.Nombre == "Camaleon");
        
            Console.Clear();
            Console.WriteLine("Nombre:        " +    camaleon.Nombre);
            Console.WriteLine("Especie:       " +   camaleon.Especie);
            Console.WriteLine("Familia:       " +   camaleon.Familia );
            Console.WriteLine("Habitat:       " +    camaleon.Habitat);
            Console.WriteLine("Longitud:      " +    camaleon.Longitud);
            Console.WriteLine("Alimentacion:  " + camaleon.Alimentacion );
            Console.WriteLine("Reproduccion:  " +     camaleon.Reproduccion);
            Console.WriteLine("");
            Console.WriteLine("Informacion: ");
            camaleon.Datos("es considerado una especie de lagarto iguanio, fácilmente distinguible por su ojos prominentes con capacidad de movimientos oculares independientes, su movimiento pausado y su capacidad de cambiar de color según las condiciones propias (situaciones fisiológicas o sociales) o externas (temperatura, camuflaje o actividad desarrollada).");

        Console.ReadLine();
    }

    
}