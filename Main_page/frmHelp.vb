Public Class Aide
    Private Sub Aide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Langue (Pays): " &
         My.Computer.Info.InstalledUICulture.DisplayName & vbCrLf & "Nom du Système d'exploitation: " &
         My.Computer.Info.OSFullName & vbCrLf & "Plateforme Système d'exploitation: " &
         My.Computer.Info.OSPlatform & vbCrLf & "Version du Système d'exploitation: " &
         My.Computer.Info.OSVersion & vbCrLf & "Available Physical Memory: " &
         My.Computer.Info.TotalPhysicalMemory & vbCrLf & "Available Virtual Memory: " &
         My.Computer.Info.TotalVirtualMemory & vbCrLf & "Mémoire Virtuelle Disponible: " &
         My.Computer.Info.AvailableVirtualMemory
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Name = "Node0" Then
            TextBoxDescription.Text = "L’introduction est l’une des parties les plus courtes du texte, mais elle est essentielle. C’est l’introduction qui attire le lecteur et qui lui donne le gout de poursuivre sa lecture. C’est aussi l’introduction qui présente succinctement le contenu du texte. Elle doit donc être bien construite pour que le lecteur soit bien préparé à la lecture.

Plus spécifiquement, l’introduction d'un texte descriptif sert à présenter le sujet du texte et la manière dont il sera présenté. Généralement, une introduction comporte trois étapes :
 

 1. Le sujet amené
 2. Le sujet posé
 3. Le sujet divisé"
        End If
        If e.Node.Name = "Node1" Then
            TextBoxDescription.Text = "Une interface définit la frontière de communication entre deux entités, comme des éléments de logiciel, des composants de matériel informatique, ou un utilisateur. Elle se réfère généralement à une image abstraite qu'une entité fournit d'elle-même à l'extérieur. Cela permet de distinguer les méthodes de communication avec l'extérieur et les opérations internes, et autorise à modifier les opérations internes sans affecter la façon dont les entités externes interagissent avec elle, en même temps qu'elle en fournit des abstractions multiples. On appelle aussi interfaces des dispositifs fournissant un moyen de traduction entre des entités qui n'utilisent pas le même langage, comme entre un être humain et un ordinateur. Étant donné que ces interfaces réalisent des traductions et des adaptations, elles entraînent des coûts de développement supplémentaires par rapport à des communications directes.

Variétés :

Une interface humain-machine permet des échanges entre un humain et une machine ;
Une interface de programmation permet des échanges entre plusieurs logiciels ;
L’interface qui est présentée à l’utilisateur est nommée interface utilisateur ;
Les interfaces entre des composants de matériel informatique sont des interfaces physiques."
        End If
        If e.Node.Name = "Node2" Then
            TextBoxDescription.Text = "Une station-service, aussi appelée station essence, station d’essence, station à essence, ou encore pompe à essence est une infrastructure positionnée sur le bord d'une route ou d'une autoroute destinée principalement à fournir du carburant aux automobilistes. Le mot « station-service » est un calque de la locution anglaise (service station).

Outre les distributeurs de carburant, les stations les plus équipées offrent aussi des services nécessaires aux véhicules automobiles : boutique d'accessoires automobiles, station de gonflage des pneumatiques, petite mécanique et dépannage. Parfois, une carte carburant peut être utilisée comme moyen de paiement. Elles proposent également des services à destination des automobilistes : toilettes, épicerie, restauration, téléphone public."
        End If
        If e.Node.Name = "Node3" Then
            TextBoxDescription.Text = "Le client est essentiel, il aura droit à des jetons pour chaque 5$ dépensé."
        End If
        If e.Node.Name = "Node4" Then
            TextBoxDescription.Text = "Saviez-vous que les pompes à essence doivent être approuvées par nous?, inspectées avant d'être utilisées? et réinspectées tous les 2 ans?

Les pompes inexactes doivent être réparées ou elles risquent d'être retirées du service.
Le propriétaire doit veiller à ce que la pompe mesure avec exactitude en tout temps.
Si l'on découvre qu'une pompe ne mesure pas avec exactitude et que le problème n'est pas corrigé rapidement, le propriétaire pourrait se voir imposer une pénalité ou une amende.
Erreur maximale

Le Règlement sur les poids et mesures tolère une erreur maximale de 100 mL (0,5 %) pour une livraison de 20 L. C'est à peu près la même quantité que la moitié d'une petite boîte de jus!

Recherchez l'étiquette d'inspection

L'étiquette indique la date de la dernière inspection de la pompe et la date de la prochaine inspection.

Nous nous concentrons sur l'exactitude de la pompe pour que vous obteniez la quantité d'essence que vous avez payée.

Plaintes sur les pompes à essence

La plupart des plaintes que nous recevons concernent :

les étiquettes d'inspection manquantes
les mesures soupçonnées inexactes
les problèmes de compensation automatique de la température (le volume est corrigé à 15 °C)
Si vous souhaitez déposer une plainte, veuillez communiquer avec nous.

Plaintes sur le prix de l'essence

Pour signaler un cas présumé de ﬁxation des prix dans le secteur de l'essence au détail ou tout autre problème lié au prix de l'essence, vous pouvez communiquer avec le Bureau de la concurrence à bureaudelaconcurrence.gc.ca."
        End If
        If e.Node.Name = "Node5" Then
            TextBoxDescription.Text = "À partir du 1er septembre 2020, les stagiaires et les étudiants stagiaires dans une industrie ou un milieu de travail sous réglementation fédérale, ont droit à ce qui suit :
Stagiaires :
ont droit de recevoir toutes les mesures de protection en vertu de la partie III du Code canadien du travail;
doivent être rémunérés au moins au salaire minimum.
Étudiants stagiaires, qui effectuent des stages afin de répondre aux exigences de leur programme d'éducation :
ont droit à certaines mesures de protections des normes du travail fédérale;
ne sont pas tenus d’être rémunérés.
Pour de plus amples informations :
Normes du travail fédérales pour les stagiaires et les étudiants stagiaires
Obligations des employeurs envers les stagiaires et les étudiants stagiaires"
        End If
        If e.Node.Name = "Node6" Then
            TextBoxDescription.Text = "Le présentéisme définit généralement le fait répété pour un employé d’être au travail, et ce, malgré des symptômes de maladie qui devraient normalement le contraindre à s’absenter. L’absentéisme, pour sa part, ne fait pas l’objet d’une définition unanimement reconnue. Certains, plus largement, le considèrent comme étant simplement la récurrence d’absences au travail. D’autres limitent ce phénomène uniquement aux absences au travail non justifiées.

Plusieurs études conçoivent l’absentéisme et le présentéisme comme l’avers et le revers de la même médaille. Par exemple, un salarié qui se présente à plusieurs reprises au travail bien qu’on lui ait prescrit du repos risque, à terme, de devoir s’absenter pour traiter les conséquences physiques et mentales de son excès de zèle.

Deux études publiées récemment ont examiné les phénomènes d’absentéisme et de présentéisme. Elles permettent, entre autres, d’en mesurer les causes et les conséquences, ce qui ne manquera pas d’interpeller tout gestionnaire en SST ou en RH.

La première est le fruit des recherches du professeur Roland Foucher de l’Université du Québec en Outaouais. Elle offre un modèle d’analyse de l’absentéisme qui permet de mieux appréhender la multicausalité de ce phénomène et de décliner certains moyens d’intervention. Riche et bien documentée, elle nous indique que :

En 2018 au Québec, l’absentéisme représentait 7 % du temps de travail, ce qui est en phase avec les données observées à l’échelle mondiale.
Remplacer un salarié absent peut occasionner des frais 2 à 3 fois supérieurs au salaire journalier versé à celui-ci.
Certains moyens pour prévenir l’absentéisme peuvent engendrer des effets contreproductifs si, par exemple, les employés les jugent injustes.
La seconde étude a été réalisée par un groupe de chercheurs issus de multiples universités et instituts suédois. Analysant l’absentéisme et le présentéisme de manière simultanée, ils précisent que :

Le présentéisme et l’absentéisme sont tout aussi nuisibles aux prestations des travailleurs et des travailleuses.
Le présentéisme pourrait davantage accroître les risques d’épuisement professionnel.
Le présentéisme serait plus à même d’entraîner de l’absentéisme, et non l’inverse.
Le présentéisme engendrerait des coûts pour les employeurs supérieurs à ceux que l’absentéisme pourrait occasionner.
À n’en point douter, ces deux études alimenteront les réflexions des gestionnaires SST et RH, à même de constater les conséquences directes de ces phénomènes dans leurs milieux de travail. Entre autres, le présentéisme peut avoir des incidences néfastes sur l’efficience et la production en entreprise, ainsi que sur la santé et la sécurité de tous les salariés ayant à traiter avec un collègue moins alerte qu’à l’accoutumée. L’absentéisme abusif, en contrepartie, peut amener une surcharge de travail pour un effectif, alors forcé d’assumer les tâches d’un ou de plusieurs employés absents.

Afin de bâtir des milieux de travail plus sains pour tout un chacun, les responsables SST et RH voudront également prêter attention aux causes de l’absentéisme et du présentéisme. L’absentéisme sans motif peut, par exemple, traduire une culture organisationnelle dysfonctionnelle, de même qu’un malaise ou un mécontentement vécu par les salariés d’une unité ou, plus largement, d’une entreprise.

En revanche, le présentéisme peut être motivé par la volonté de ne pas laisser des collègues en plan ou de maintenir une image professionnelle forte, par la peur de perdre son emploi ou d’être mal perçu au sein de l’organisation, ou encore par la volonté de respecter des délais serrés imposés pour accomplir certaines tâches."
        End If
        If e.Node.Name = "Node7" Then
            TextBoxDescription.Text = "L'état d'urgence désigne un régime exceptionnel, mis en place par un gouvernement, en cas d'atteinte grave à l'ordre public, de troubles graves ou de calamités nationales. Il se traduit par un renforcement des pouvoirs de l'autorité administrative, notamment des pouvoirs de police, des restrictions de certaines libertés publiques ou individuelles pour des personnes considérées comme dangereuses : contrôle de la presse, limitation de circulation des personnes ou des véhicules, expulsions du territoire, interdiction de réunion, assignation à résidence, etc.

L'état d'urgence peut être proclamé sur tout le territoire ou sur une partie de celui-ci. Même s'il est prévu par la loi, l'état d'urgence est une mise entre parenthèses de l'Etat de droit au profit du maintien de l'ordre public."
        End If
        If e.Node.Name = "Node8" Then
            TextBoxDescription.Text = "Quoi faire en cas d’incendie
Si un incendie se déclare, votre premier réflexe doit être de quitter les lieux. L’évacuation sera rapide et efficace si elle a été préparée.

Si vous pénétrez dans un immeuble d’habitation ou un édifice public pour la première fois, repérez les issues de secours, qui sont indiquées au moyen de panneaux portant la mention «SORTIE» ou «EXIT».

Votre propriétaire a la responsabilité d’établir un plan et une procédure d’évacuation et de vous en informer. Si vous n’avez pas reçu d’information à ce sujet, parlez-en avec votre propriétaire.

Comme locataire, vous avez également votre part de responsabilité. Ne laissez jamais d’obstacles encombrer le parcours qui conduit aux issues. Durant la saison hivernale, déblayez votre balcon ainsi que les marches et les voies d’accès extérieures.

En cas d’incendie
Si vous détectez un incendie (odeur de fumée, crépitement):

déclenchez le système d’alarme.
quittez l’immeuble immédiatement.
avisez le service d’incendie.
Si vous entendez le système d’alarme:

laissez tous vos effets personnels.
touchez la porte avant de l’ouvrir. Si elle est chaude, il y a vraisemblablement des flammes ou des gaz de l’autre côté; dans ce cas, n’ouvrez pas la porte.
si la porte n’est pas chaude, ouvrez-la lentement pour vous assurer qu’il n’y a pas de danger de l’autre côté.
dirigez-vous rapidement vers l’issue la plus proche si aucun danger ne vous menace. S’il y a de la fumée, déplacez-vous en rampant. Soyez toujours prêt à rebrousser chemin si l’accès à la sortie est obstrué par la fumée ou les flammes.
ne prenez jamais l’ascenseur.
Si vous devez rester dans votre logement parce qu’un danger plus grand vous menace à l’extérieur:

téléphonez à votre service d’incendie pour signaler votre présence dans l’immeuble (gardez toujours le numéro du service d’incendie à votre portée).
bloquez les espaces vides autour de la porte à l’aide de serviettes ou de draps mouillés pour éviter que la fumée ne pénètre dans votre logement.
respirez au travers d’un linge humide, s’il y a de la fumée.
ouvrez une fenêtre, mais préparez-vous à la refermer rapidement si la fumée pénètre à l’intérieur.
allez sur le balcon si vous croyez que la fumée et les flammes ne vous atteindront pas ou placez-vous devant une fenêtre afin d’être repéré."
        End If
        If e.Node.Name = "Node9" Then
            TextBoxDescription.Text = "Appelez la police!
Dès que vous constatez une entrée par effraction ou un vol, appelez le service de police et ne touchez à rien jusqu'à l'arrivée des policiers.
Un rapport de police est nécessaire dans le traitement de votre réclamation.
Mesures à prendre à la suite d'un vol
Sécurisez les lieux au besoin, afin d'éviter entre autres que les dommages ne s'aggravent (ex. : réparez temporairement une fenêtre).
Faites une liste sommaire des biens volés ou détruits et des dommages à la résidence."
        End If
        If e.Node.Name = "Node10" Then
            TextBoxDescription.Text = "Foires aux Questions"
        End If
    End Sub
End Class