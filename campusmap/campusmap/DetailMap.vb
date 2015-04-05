Imports System.IO

Public Class DetailMap
    Public picsaikat As Image
    Public txtsaikat As String
    Public cursorPos As Point
    ' Global variables
    Const TOOLTIP_SIZE As Integer = 75
    Const REC_WIDTH As Integer = 1366, REC_HEIGHT As Integer = 768
    Const SCREEN_WARNING As String = "WARNING: Your screen resolution is not recommended. Some functionality might appear incorrectly"
    Dim cursize As Size
    Dim curloc As Point
    Dim warningCode As Integer = 0
    Dim isDeactivated As Boolean = False
    Dim curLabelHover As Label = Nothing

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SetLabelParents()   'Function to set the parent of label to the picture box
    End Sub

    Protected Function ResizeImage(ByRef imgSource As Image, ByVal sizeX As Integer, ByVal sizeY As Integer)  ' make the size of the image sizeX x sizeY
        'resize the image by percent
        Dim bm As Drawing.Bitmap = New System.Drawing.Bitmap(sizeX, sizeY)
        Dim g As System.Drawing.Graphics = Drawing.Graphics.FromImage(bm)
        g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.NearestNeighbor   'To ensure that the image quality is not compromised because of the system
        g.DrawImage(imgSource, 0, 0, sizeX, sizeY)
        Return bm
    End Function

    ' Called when Mouse leaves from an image
    Private Sub label_MouseLeave(sender As Object, e As EventArgs) Handles facultyHall.MouseLeave, marketComplex.MouseLeave, dblock.MouseLeave, bblock.MouseLeave, serp.MouseLeave, dblock2.MouseLeave, cblock.MouseLeave, eblock2.MouseLeave, eblock.MouseLeave, fblock1.MouseLeave, dblock3.MouseLeave, fblock2.MouseLeave, tennis.MouseLeave, subansiri.MouseLeave, studentactivity.MouseLeave, hockey.MouseLeave, football.MouseLeave, fblock4.MouseLeave, fblock3.MouseLeave, athletic.MouseLeave, married.MouseLeave, aseb.MouseLeave, guestlake.MouseLeave, guesthouse.MouseLeave, watertreatment.MouseLeave, umium.MouseLeave, tc.MouseLeave, swim.MouseLeave, siang.MouseLeave, phy.MouseLeave, mech.MouseLeave, mch.MouseLeave, manas.MouseLeave, lt.MouseLeave, kv.MouseLeave, kapili.MouseLeave, kameng.MouseLeave, iitglake.MouseLeave, hss.MouseLeave, hospital.MouseLeave, environment.MouseLeave, energy.MouseLeave, eee.MouseLeave, dihing.MouseLeave, dibang.MouseLeave, dd.MouseLeave, cse.MouseLeave, cricket.MouseLeave, conference.MouseLeave, chem.MouseLeave, cet.MouseLeave, ce.MouseLeave, cc.MouseLeave, bt.MouseLeave, brahmo.MouseLeave, barak.MouseLeave, audi.MouseLeave, akshara.MouseLeave, admin.MouseLeave, ac.MouseLeave, mainGate.MouseLeave
        Try
            If Not isDeactivated Then
                Dim caller As Label
                caller = CType(sender, Label)
                caller.Cursor = Cursors.Arrow
                caller.Size = cursize
                caller.SendToBack()
                caller.Image = Nothing
                curloc.X = caller.Location.X + (TOOLTIP_SIZE) / 4
                curloc.Y = caller.Location.Y + (TOOLTIP_SIZE) / 4
                caller.Location = curloc
                'Console.WriteLine(caller.Name + "-->" + caller.Location.X.ToString + " " + caller.Location.Y.ToString)
                ToolStripStatusLabel2.Text = ""
                Label2.Text = ""
                curLabelHover = Nothing
                Console.WriteLine("Mouse hovering FALSE over " + caller.Name)
            End If
            ' To Handle the Exceptions
        Catch ex As Exception
            MsgBox("An unexpected technical error occured [MouseLeave]....\n\n" + ex.ToString)
        End Try

    End Sub

    ' called when Mouse Enters the label
    Private Sub label_MouseEnter(sender As Object, e As EventArgs) Handles facultyHall.MouseEnter, marketComplex.MouseEnter, dblock.MouseEnter, bblock.MouseEnter, serp.MouseEnter, dblock2.MouseEnter, cblock.MouseEnter, eblock.MouseEnter, eblock2.MouseEnter, fblock1.MouseEnter, dblock3.MouseEnter, fblock2.MouseEnter, tennis.MouseEnter, subansiri.MouseEnter, studentactivity.MouseEnter, hockey.MouseEnter, football.MouseEnter, fblock4.MouseEnter, fblock3.MouseEnter, athletic.MouseEnter, married.MouseEnter, aseb.MouseEnter, guestlake.MouseEnter, guesthouse.MouseEnter, watertreatment.MouseEnter, umium.MouseEnter, tc.MouseEnter, swim.MouseEnter, siang.MouseEnter, phy.MouseEnter, mech.MouseEnter, mch.MouseEnter, manas.MouseEnter, lt.MouseEnter, kv.MouseEnter, kapili.MouseEnter, kameng.MouseEnter, iitglake.MouseEnter, hss.MouseEnter, hospital.MouseEnter, environment.MouseEnter, energy.MouseEnter, eee.MouseEnter, dihing.MouseEnter, dibang.MouseEnter, dd.MouseEnter, cse.MouseEnter, cricket.MouseEnter, conference.MouseEnter, chem.MouseEnter, cet.MouseEnter, ce.MouseEnter, cc.MouseEnter, bt.MouseEnter, brahmo.MouseEnter, barak.MouseEnter, audi.MouseEnter, akshara.MouseEnter, admin.MouseEnter, ac.MouseEnter, mainGate.MouseEnter
        Try
            If Not isDeactivated Then
                Dim caller As Label = CType(sender, Label)
                caller.Cursor = Cursors.Hand    'Changes cursor style from arrow to hand
                Me.cursize = caller.Size
                caller.Size = New Size(New Point(TOOLTIP_SIZE, TOOLTIP_SIZE))
                caller.BringToFront()
                caller.Image = ResizeImage(GetImage(caller.Name), TOOLTIP_SIZE, TOOLTIP_SIZE)
                curloc.X = caller.Location.X - (TOOLTIP_SIZE) / 4
                curloc.Y = caller.Location.Y - (TOOLTIP_SIZE) / 4
                caller.Location = curloc
                ToolStripStatusLabel2.Text = StrConv(caller.Name, VbStrConv.ProperCase)
                Label2.Text = "Current Location: " + vbNewLine + StrConv(GetData(caller.Name, 3), VbStrConv.ProperCase) 'Current item is displayed in the rich textbox
                curLabelHover = caller
                Console.WriteLine("Mouse hovering true over " + caller.Name)
            End If
        Catch ex As Exception
            MsgBox("An unexpected technical error occured [MouseEnter]....\n\n" + ex.ToString)
        End Try
    End Sub

    '   Used to get the information of item clicked or hovered with the help of the ID of the item passed as an argument to this function
    Protected Function GetData(caller As String, mode As Integer) As String
        If mode = 1 Then    ' If this mode is selected then image name is returned
            Console.WriteLine(caller)
            Select Case caller
                Case "ac"
                    Return "acplant"
                Case "admin"
                    Return "adminbldg"
                Case "akshara"
                    Return "akshara"
                Case "aseb"
                    Return "aseb"
                Case "athletic"
                    Return "athfield"
                Case "audi"
                    Return "auditorium"
                Case "barak"
                    Return "barak"
                Case "bt"
                    Return "biotechnology"
                Case "brahmo"
                    Return "brahmo"
                Case "bblock"
                    Return "bblock"
                Case "cblock"
                    Return "cblock"
                Case "environment"
                    Return "cet"
                Case "cet"
                    Return "cee"
                Case "chem"
                    Return "chem"
                Case "ce"
                    Return "civil"
                Case "facultyHall"
                    Return "chs"
                Case "cc"
                    Return "cc"
                Case "conference"
                    Return "confhall"
                Case "cricket"
                    Return "cric"
                Case "cse"
                    Return "cse"
                Case "cblock"
                    Return "cblock"
                Case "dd"
                    Return "design"
                Case "dibang"
                    Return "dibang"
                Case "dihing"
                    Return "dihing"
                Case "dblock"
                    Return "dblock"
                Case "dblock2"
                    Return "dblock"
                Case "dblock3"
                    Return "dblock"
                Case "eee"
                    Return "EEE"
                Case "eblock"
                    Return "eblock"
                Case "energy"
                    Return "power"
                    Return "eblock"
                Case "eblock2"
                    Return "eblock"
                Case "football"
                    Return "football"
                Case "guesthouse"
                    Return "guesth"
                Case "hockey"
                    Return "hockey"
                Case "hospital"
                    Return "hospital"
                Case "hss"
                    Return "hss"
                Case "guestlake"
                    Return "serp"
                Case "serp"
                    Return "serp"
                Case "iitglake"
                    Return "lake"
                Case "kameng"
                    Return "kameng"
                Case "kapili"
                    Return "kapili"
                Case "kv"
                    Return "kv"
                Case "ac"
                    Return "lake"
                Case "manas"
                    Return "manas"
                Case "marketComplex"
                    Return "market_complex"
                Case "married"
                    Return "married"
                Case "mech"
                    Return "mech"
                Case "phy"
                    Return "phy"
                Case "guesthouse"
                    Return "guesth"
                Case "siang"
                    Return "siang"
                Case "subansiri"
                    Return "subansiri"
                Case "swim"
                    Return "pool"
                Case "tc"
                    Return "tc"
                Case "tennis"
                    Return "tennis"
                Case "umium"
                    Return "umiam"
                Case "watertreatment"
                    Return "water"
                Case "facultyhall"
                    Return "chs"
                Case "fblock1"
                    Return "eblock"
                Case "fblock2"
                    Return "eblock"
                Case "fblock3"
                    Return "eblock"
                Case "fblock4"
                    Return "eblock"
                Case "lt"
                    Return "lt"
                Case "mainGate"
                    Return "main_gate"
                Case "mch"
                    Return "mch"
                Case "studentactivity"
                    Return "sac"
                Case "ac"
                    Return "acplant"
            End Select
        ElseIf mode = 2 Then    'If this mode is selected then the description is returned
            Select Case caller
                Case "ac"
                    Return "The AC plant provides air conditioning facility to the whole academic complex of IIT Guwahati."
                Case "admin"
                    Return "The building consists of all the major administration sections like accounts, student affairs, faculty affairs, placement cell, registrar's office, public relations, stores and purchase, research and development, establishment, engineering section and of course the Director's office. The base of the building also has a restaurant and two banks for the access of junta at IITG"
                Case "akshara"
                    Return "Akshara Pre-Primary School : It is the only pre primary school uder the institute premise located near ASEB gate."
                Case "aseb"
                    Return "ASEB Gate: One of the entrance/exit gate of IITG."
                Case "athletic"
                    Return "Athletic Field: Part of the immense grounds and sports facilities that are carefully maintained in order to provide a holistic environment to the IITG Fraternity"
                Case "audi"
                    Return "One of the major attractions at IITG is its 1500 seater auditorium. The state of the art facilities provides amazing experience of every event happening inside. The auditorium building boasts an area of 5895 sq. mts. Apart from a conference hall, green room, projector room, it also has a 180 seater mini auditorium. The acoustics of the auditorium are built with exceptional quality to hear the incredible sound of the Bose sound system. The push back chairs, floor and stage furnishing completes your experience as a lifetime experience. It is also secured with fire detection alarm system and fire extinguishers at required places"
                Case "barak"
                    Return "Barak is the 7th hostel in the IITG fraternity and derives its name from the River Barak which is a major river in north-eastern India and is a part of the Surma-Meghna River System. It was previously only for M.Tech and PhD. Students but from 2011 onwards the hostel also has boarders of B.Tech."
                Case "bt"
                    Return "Contributing to the fascinating and emerging areas of Science, IIT Guwahati established Department of Biotechnology in the year 2002. The Department is one of its kind in the north-eastern region of Indian sub-continent and is dedicated for promoting goal-oriented interdisciplinary research by interfacing modern biology with applied engineering sciences, addressing problems affecting human health/welfare, and training students to be the next generation engineers and researchers. As of now, the department has twenty-seven faculty members from diverse streams and specializations, eight well-trained scientific staff members, two administrative staff members, 141 students in the B. Tech programme, 57 students in the M. Tech programme and 95 students in the Ph.D. programme. Till date, degrees have been awarded to 141 B. Tech students, 35 M. Tech students, and 29 Ph. D. Students."
                Case "brahmo"
                    Return "The Hostel Brahmaputra was opened for students in the academic year 2011 - 2012. The Hostel spreads in four blocks . At present the hostel accommodates more than 1000 students majority of them are either M.Tech or Ph.D from different disciplines and a few are from B.Tech. "
                Case "bblock"
                    Return "B-Type Quarters"
                Case "cblock"
                    Return "C-Type Quarters"
                Case "environment"
                    Return "Centre for the Environment was established in May 2004 with the main objective to promote interdisciplinary research and development, to impart postgraduate education, to create public awareness, to provide consultancy in challenging area and to train manpower for mitigating emerging environmental problems. Centre for the Environment offers PhD programme intended for the students who are interested in carrying out distinguished scholarly activities in the interdisciplinary domains of environmental issues."
                Case "cet"
                    Return "Centre for Educational Technology, a central facility of the Institute, is involved in Research, Design and Development of Educational Learning Content & its Technology. The centre coordinates the QIP Masters and PhD students' activities studying in various departments & centers of the Institute. It conducts Short Term courses & Training Programs for industry & institutions. Through its Curriculum Development Cell it develops pedagogy strategies & syllabus development for courses at IITG It extends collaboration and academic support to student's working on their thesis and projects in the area of ICT based Education, E- learning & Web Content Design."
                Case "chem"
                    Return "Started in 2002, the department is a major academic host offering all degree programmes such as B.Tech., M.Tech. and Ph.D. in Chemical Engineering. The department offers Petroleum Science & Technology (PST) and Materials Science & Technology (MST) as specializations in the master curriculum. Since inception, the department is endowed with young, vibrant, dynamic and qualified faculty to impart high quality teaching and research in conventional and frontier areas of Chemical Engineering and Refinery Engineering."
                Case "ce"
                    Return "The department started in 1999. The department educates students at all degree levels that meet the present and future engineering needs of the country. Students are given the theoretical engineering knowledge accompanied by laboratory and field practice. Emphasis is given to develop professional leadership skills and a strong sense of responsibility to take up challenging problems in Civil Engineering. The main areas of research include Geotechnical Engineering, Structural Engineering, Hydraulics Engineering, Hydrology, GIS and GPS Systems, Design of Structures, Environmental Engineering, Solid Mechanics and Transportation Engineering. The department also handles consultancy works and projects."
                Case "facultyHall"
                    Return "The Faculty Hall provides a place to faculty for organising events. It is situated near to all faculty quarters."
                Case "cc"
                    Return " The Computer & Communication Centre remains open for seventeen hours in a day and the students visit the Centre for their routine computing task. Besides the resources of the Computer Center is used by the departments to conduct their practical courses.The CSE dept conducts their computer programming practical in the Centre for the first year Btech students, the Mechanical Engineering Dept uses the Centre for their engineering drawing practical, students of ECE dept. use the Centre resources to work on Matlab. Likewise all the other departments conduct some of their labs in the Centre."
                Case "conference"
                    Return "A Conference Centre with a provision of 4 halls (2 halls with 150 capacity and 2 halls with 200 capacity) serves as a best place for organising big professional events."
                Case "cricket"
                    Return "Cricket Field: Part of the immense grounds and sports facilities that are carefully maintained in order to provide a holistic environment to the IITG Fraternity"
                Case "cse"
                    Return "The Department of Computer Science and Engineering at the Indian Institute of Technology Guwahati, was formed in 1995. Since its inception, the Department has always been recognized all over the world for excellence in research and teaching. The Department provides an outstanding research environment complemented by superior teaching for its students to flourish in. In March 2012, the Department has 25 faculty members, 7 supporting staff members, 336 students in the B. Tech programme, 105 students in the M. Tech programme and 53 students in the Ph.D. programme. Till date, degrees have been awarded to 518 B. Tech students, 303 M. Tech students, and 8 Ph. D. Students."
                Case "cblock"
                    Return "cblock"
                Case "dd"
                    Return "The Department of Design(DoD), one of the thirteen departments at IIT Guwahati, was set up with a vision to enkindle some of the brightest technical minds of the country a passion for innovation in technology driven by a firm understanding, appreciation and celebration of design. The focus of the programs here is on the study, invention, and creative use of technologies to create effective, usable, enjoyable experiences through interdisciplinary research in engineering, design, behavioral and social sciences, and to understand the impact of technology on individuals, groups, and organizations. The department envisions to produce successful graduates who will be capable of leading the changing scenarios of today and tomorrow through thought, innovation and values."
                Case "dibang"
                    Return "Hostel Dibang came into being in July 2010 as the eighth boys' hostel of IIT Guwahati. The name Dibang follows the tradition of naming hostels of IIT Guwahati after benevolent rivers and valleys of Northeast India. Being the home of most of the MTech, MDes, MA, PhD and Project Staff of various departments and centres of the Institute, Dibang is reputed for its comparatively peaceful environment."
                Case "dihing"
                    Return "Named after a tributary of the Brahmaputra, Dihing Hostel is situated just beside the newly built Brhahmaputra Hostel. This 300 seater boys' hostel was established during 2000."
                Case "dblock"
                    Return "D-Type Quarters"
                Case "dblock2"
                    Return "D-Type Quarters"
                Case "dblock3"
                    Return "D-Type Quarters"
                Case "eee"
                    Return "The department was established during the inception of the institute in 1995. Since its commencement, the primary objective of the department has been to impart quality education, training and research at the undergraduate, postgraduate and doctoral levels in various areas of Electronics and Communication Engineering with broad emphasis on design aspects of electronic systems. The major areas of faculty expertise of the department include Communications, Advanced DSP, Biomedical and Speech Processing, Control, Instrumentation, VLSI, Image Processing and Computer Vision."
                Case "eblock"
                    Return "E-Type Quarters"
                Case "energy"
                    Return "The Centre for Energy at IIT Guwahati was established in 2004 with an objective to promote multidisciplinary activities focused to various facets of energy technology and systems in the form of research, teaching and consultancy. Currently the centre offers only PhD program, which was started in the year 2005."
                Case "eblock2"
                    Return "E-Type Quarters"
                Case "football"
                    Return "Football Field: Part of the immense grounds and sports facilities that are carefully maintained in order to provide a holistic environment to the IITG Fraternity"
                Case "guesthouse"
                    Return "Guesthouse: The institute has a beautiful guest house which is used to accommodate invitees, important personalities and guardians of students of the institute. The beautiful design of guest house makes it possible for most of the rooms to enjoy the scenic beauty of serpentine lake and surroundings. The dining in the guest house is believed to serve the best food available in the campus. The current guest house consists of 60 rooms and a new guest house is under construction to accommodate more people."
                Case "hockey"
                    Return "Hockey Field: Part of the immense grounds and sports facilities that are carefully maintained in order to provide a holistic environment to the IITG Fraternity"
                Case "hospital"
                    Return "The IIT Guwahati Hospital is located inside the scenic IIT Guwahati campus..IITG hospital has an Emergency Room, Minor OT room, ECG Room, 10 numbers of Patient Cabin, 02 numbers of Isolation Cabin and 02 numbers of General Ward.Hospital has 24 hrs Doctor, Nursing and Pharmacy service for its patients provided by outsourced hospital service provider. It has a Reception Counter for Patients registration, Diagnostics Laboratory with specimen collection facility for its patients from 8.00 PM to 1.00 PM provided by outsourced hospital service provider. The Hospital also has two ambulances for patient care. "
                Case "hss"
                    Return "The Department of Humanities and Social Sciences consists of eight academic disciplines, viz. Economics, English, Linguistics, Philosophy, Psychology, Sociology and History & Archeology and Political Science. The department offers courses for students at B Tech, M.A. and Ph. D level. "
                Case "guestlake"
                    Return "This lake is  situated near to the guest house lake which adds a beauty to the guest house."
                Case "serp"
                    Return "Known as Serpentine Lake, it is situated near to the faculty quareters and guest house."
                Case "iitglake"
                    Return "IITG lake is a landmark of iitg. This lake provides iit its beauty and constitutes a major role in making iit guwahati on of the most beautiful campuses. "
                Case "kameng"
                    Return "Kameng Hostel is named after the tributary Kameng of the mighty river Bramhaputra. Kameng has 504 rooms distributed over five blocks(B1,B2,B3,B4 and C1).The B blocks have 30 rooms on each floor while the C1 block has eight rooms on each floor."
                Case "kapili"
                    Return "Hostel Kapili: Mostly undergraduate students reside in this 300 capacity hostel. The hostel has a reading room, table tennis room, television room and music room to ensure a pleasant stay to all the boarders. In addition, the hostel has a juice centre, canteen and stationery shop to cater the need of the students."
                Case "kv"
                    Return "Kendriya Vidyalaya IITG has finally realised its vision of growing itself into a full fledged Higher Secondary School with a well designed building that accommodate well equipped laboratories , adequate library facilities, furnished classrooms with modern amenities, teaching aids, playground, etc. to render teaching learning enjoyable and effective. Well trained, dedicated teachers in respective fields selected on the basis of nationwide tests are appointed."
                Case "manas"
                    Return "Manas, is the first hostel of IIT Guwahati and has been the home for some of India's best for the last 15 years. This hostel was previously a co-ed hostel; however it is currently a boys only hostel"
                Case "marketComplex"
                    Return "Market Complex provides common facilitise like general store, tailor, hair saloon to the students as well as faculties."
                Case "married"
                    Return "IIT Guwahati provides special Hostels to the Married Scholars of IITG,  which provides 2 rooms and one kitchen for each married scholar."
                Case "mech"
                    Return "The department of mechanical engineering at the IIT Guwahati was formed in 1995. The department is recognized all over the world for its involvement in excellent research and teaching. The focus of the department has been in developing the state-of-art computational and experimental facilities for teaching and research activities.The Department has excellent laboratories well-stocked with state-of-the-art technical equipment and apparatus. There are 14 different laboratories in the department.The faculty strength of the department is 34 along with 27 supporting staff. Since its inception, the department has awarded 426 B.Tech, 322 M.Tech and 31 PhD degrees."
                Case "phy"
                    Return "The department came into existence in 1995 and since then undertook an unwearied effort to live up to the expectations of the community and society at large by imparting quality education to the students of the institute. In order to achieve the goal of quality teaching, the teaching and research laboratories are being continuously upgraded with state-of-the art equipment and other infrastructure facilities. Presently, the department has 27 faculty members, one scientific officer, 6 technical staff members"
                Case "guesthouse"
                    Return "The institute has a beautiful guest house which is used to accommodate invitees, important personalities and guardians of students of the institute. The beautiful design of guest house makes it possible for most of the rooms to enjoy the scenic beauty of serpentine lake and surroundings. The dining in the guest house is believed to serve the best food available in the campus. The current guest house consists of 60 rooms and a new guest house is under construction to accommodate more people. "
                Case "siang"
                    Return "Siang hostel came into being on July 2003 as the fourth boys' hostel of IIT Guwahati. The name Siang follows the same revered tradition of naming hostels of IIT Guwahati after benevolent rivers of north-east India. Being the home of some of the M.Tech.,M.Sc., PhD. and Project Staffs of various specializations of the Institute, Siang is reputed for its peaceful environment"
                Case "subansiri"
                    Return "Inaugurated in 2003, Subansiri is the 1st girls' hostel in the campus. Named after the largest tributary of the Brahmaputra, this hostel houses research scholars, UGs and PGs. Over the last couple of years, it has grown to accommodate 503 students."
                Case "swim"
                    Return "Swimming Pool: The 50 metre long and 24 feet deep world class swimming pool leaves you in awe. The 42nd Inter IIT Aquatics Meet was held here. It has a fully functioning filtration plant and also facilitates playing water polo. You can also dive from enthralling three stage diving platform that goes as high as 19 feet. The sanitation of the pool is always kept as a priority and thus is well maintained. Necessary apparel and equipment can be bought from the pool itself."
                Case "tc"
                    Return "Technology complex and Guwahati Biotech Park: GBP is a visionary project launched by an autonomous society under the Government of Assam and located near Kameng hostel. The founders of the GBP hope to change the economic condition of the region and the state, thereby increasing the opportunities for the citizens of North Eastern and Eastern India."
                Case "tennis"
                    Return "Tennis Courts: Part of the immense grounds and sports facilities that are carefully maintained in order to provide a holistic environment to the IITG Fraternity"
                Case "umium"
                    Return "Inaugurated in 2008, Umiam hostel was the 8th hostel in IITG. The origin of the name came from the river Umiam originating from Meghalaya."
                Case "watertreatment"
                    Return "Water treatement plant provides brahmaputra water after cleaning, to whole IITG."
                Case "facultyhall"
                    Return "chs"
                Case "fblock1"
                    Return "F-Type Quarters"
                Case "fblock2"
                    Return "F-Type Quarters"
                Case "fblock3"
                    Return "F-Type Quarters"
                Case "fblock4"
                    Return "F-Type Quarters"
                Case "lt"
                    Return "Known as Letcture Theater complex, it consists of 4 lecture theaters(capacity 150). It is used for Academic purpose."
                Case "mainGate"
                    Return "The main gate of IIT Guwahati."
                Case "mch"
                    Return "Manas Community Hall: It a community hall located beside Manas hostel genarally for the purpose of organising cultural programs. "
                Case "studentactivity"
                    Return "Stuent Activity Center(SAC) provides a place for the students to recreate and playing their favourite indoor games. SAC has badminton court, Table tennis court, squash court."
            End Select
        ElseIf mode = 3 Then
            Select Case caller
                Case "ac"
                    Return "A/C Plant"
                Case "admin"
                    Return "Administration Building"
                Case "akshara"
                    Return "Akshara Pre-primary School"
                Case "aseb"
                    Return "ASEB Gate"
                Case "athletic"
                    Return "Athletic Field"
                Case "audi"
                    Return "Auditorium"
                Case "barak"
                    Return "Barak Hostel"
                Case "bt"
                    Return "Biotechnology Department"
                Case "brahmo"
                    Return "Brahmaputra Hostel"
                Case "bblock"
                    Return "B-Type Quarters"
                Case "cblock"
                    Return "C-Type Quarters"
                Case "environment"
                    Return "Centre for Environment Technology"
                Case "cet"
                    Return "Center for Educational Technology"
                Case "chem"
                    Return "Chemistry Department"
                Case "ce"
                    Return "Civil Engineering Department"
                Case "facultyHall"
                    Return "Community Hall"
                Case "cc"
                    Return "Library and Computer Center"
                Case "conference"
                    Return "Conference Hall"
                Case "cricket"
                    Return "Cricket Field"
                Case "cse"
                    Return "CSE Department"
                Case "cblock"
                    Return "C-Type Quarters"
                Case "dd"
                    Return "Department of Design"
                Case "dibang"
                    Return "Dibang Hostel"
                Case "dihing"
                    Return "Dihing Hostel"
                Case "dblock"
                    Return "D-Type Quarters"
                Case "dblock2"
                    Return "D-Type Quarters"
                Case "dblock3"
                    Return "D-Type Quarters"
                Case "eee"
                    Return "EEE Department"
                Case "eblock"
                    Return "E-Type Quarters"
                Case "energy"
                    Return "Centre for Energy"
                Case "eblock2"
                    Return "E-Type Quarters"
                Case "football"
                    Return "Football Field"
                Case "guesthouse"
                    Return "Guesthouse"
                Case "hockey"
                    Return "Hockey Field"
                Case "hospital"
                    Return "IITG Hospital"
                Case "hss"
                    Return "HSS Department"
                Case "guestlake"
                    Return "Guesthouse Lake"
                Case "serp"
                    Return "Lake Serpentine"
                Case "iitglake"
                    Return "IITG Lake"
                Case "kameng"
                    Return "Kameng Hostel"
                Case "kapili"
                    Return "Kapili Hostel"
                Case "kv"
                    Return "Kendriya Vidyalaya"
                Case "manas"
                    Return "Manas Hostel"
                Case "marketComplex"
                    Return "Market Complex"
                Case "married"
                    Return "Married Scholars Hostel"
                Case "mech"
                    Return "Mechanical Engineering Dept"
                Case "phy"
                    Return "Department of Physics"
                Case "siang"
                    Return "Siang Hostel"
                Case "subansiri"
                    Return "Subansiri Hostel"
                Case "swim"
                    Return "Swimming Pool"
                Case "tc"
                    Return "Technology Centre(TC)"
                Case "tennis"
                    Return "Tennis Courts"
                Case "umium"
                    Return "Umiam Hostel"
                Case "watertreatment"
                    Return "Water Treatment Plant"
                Case "facultyhall"
                    Return "Community Hall"
                Case "fblock1"
                    Return "F=Type Quarters"
                Case "fblock2"
                    Return "F-Type Quarters"
                Case "fblock3"
                    Return "F-Type Quarters"
                Case "fblock4"
                    Return "F-Type Quarters"
                Case "lt"
                    Return "Lecture Theatres"
                Case "mainGate"
                    Return "Main Gate"
                Case "mch"
                    Return "Manas Community Hall"
                Case "studentactivity"
                    Return "Students' Activity Centre"
            End Select
        End If
    End Function

    Protected Function GetImage(caller As String) As Image    'This function is used to get the image
        Dim t As String = GetData(caller, 1)
        If String.IsNullOrEmpty(t) Then
            Return My.Resources.ResourceManager.GetObject(caller)
        Else
            Return My.Resources.ResourceManager.GetObject(t)
        End If
    End Function

    Private Sub SetLabelParents()   'This set the parents of all the label as picturebox1
        ac.Parent = PictureBox1
        admin.Parent = PictureBox1
        akshara.Parent = PictureBox1
        aseb.Parent = PictureBox1
        athletic.Parent = PictureBox1
        audi.Parent = PictureBox1
        barak.Parent = PictureBox1
        bt.Parent = PictureBox1
        brahmo.Parent = PictureBox1
        bblock.Parent = PictureBox1
        cblock.Parent = PictureBox1
        environment.Parent = PictureBox1
        energy.Parent = PictureBox1
        chem.Parent = PictureBox1
        cet.Parent = PictureBox1
        ce.Parent = PictureBox1
        facultyHall.Parent = PictureBox1
        cc.Parent = PictureBox1
        conference.Parent = PictureBox1
        cricket.Parent = PictureBox1
        cse.Parent = PictureBox1
        cblock.Parent = PictureBox1
        dd.Parent = PictureBox1
        dibang.Parent = PictureBox1
        dihing.Parent = PictureBox1
        dblock.Parent = PictureBox1
        dblock2.Parent = PictureBox1
        dblock3.Parent = PictureBox1
        eee.Parent = PictureBox1
        energy.Parent = PictureBox1
        eblock.Parent = PictureBox1
        eblock2.Parent = PictureBox1
        football.Parent = PictureBox1
        guesthouse.Parent = PictureBox1
        hockey.Parent = PictureBox1
        hospital.Parent = PictureBox1
        hss.Parent = PictureBox1
        guestlake.Parent = PictureBox1
        iitglake.Parent = PictureBox1
        kameng.Parent = PictureBox1
        kapili.Parent = PictureBox1
        kv.Parent = PictureBox1
        ac.Parent = PictureBox1
        manas.Parent = PictureBox1
        marketComplex.Parent = PictureBox1
        married.Parent = PictureBox1
        mech.Parent = PictureBox1
        phy.Parent = PictureBox1
        siang.Parent = PictureBox1
        subansiri.Parent = PictureBox1
        swim.Parent = PictureBox1
        tc.Parent = PictureBox1
        tennis.Parent = PictureBox1
        umium.Parent = PictureBox1
        watertreatment.Parent = PictureBox1
        fblock1.Parent = PictureBox1
        fblock2.Parent = PictureBox1
        fblock3.Parent = PictureBox1
        fblock4.Parent = PictureBox1
        lt.Parent = PictureBox1
        mainGate.Parent = PictureBox1
        mch.Parent = PictureBox1
        serp.Parent = PictureBox1
        guesthouse.Parent = PictureBox1
        studentactivity.Parent = PictureBox1
        '  Dim valueX() As String = My.Resources.XData.Split("|"c)
        ' Dim valueY() As String = My.Resources.YData.Split("|"c)
        'Dim a As Point
        'a.X = Me.Size.Width * CType(valueX(Array.IndexOf(valueX, "mainGate") + 1), Double)
        'a.Y = Me.Size.Height * CType(valueY(Array.IndexOf(valueY, "mainGate") + 1), Double)
        ' mainGate.Location = a
    End Sub


    ' This is called to show the image and the description of label clicked
    Private Sub label_Click(sender As Object, e As EventArgs) Handles guestlake.Click, mainGate.Click, watertreatment.Click, umium.Click, tennis.Click, tc.Click, swim.Click, subansiri.Click, studentactivity.Click, siang.Click, serp.Click, phy.Click, mech.Click, mch.Click, married.Click, marketComplex.Click, manas.Click, lt.Click, kv.Click, kapili.Click, kameng.Click, iitglake.Click, hss.Click, hospital.Click, hockey.Click, guesthouse.Click, football.Click, fblock4.Click, fblock3.Click, fblock2.Click, fblock1.Click, facultyHall.Click, environment.Click, energy.Click, eee.Click, eblock2.Click, eblock.Click, dihing.Click, dibang.Click, dd.Click, dblock3.Click, dblock2.Click, dblock.Click, cse.Click, cricket.Click, conference.DoubleClick, chem.Click, cet.Click, ce.Click, cc.Click, cblock.Click, bt.Click, brahmo.Click, bblock.Click, barak.Click, audi.Click, athletic.Click, aseb.Click, akshara.Click, admin.Click, ac.Click
        Try
            Dim caller As Label = CType(sender, Label)
            picsaikat = ResizeImage(GetImage(caller.Name), 500, 500)
            Label2.Text = "Current Location: " + vbNewLine + StrConv(GetData(caller.Name, 3), VbStrConv.ProperCase)
            txtsaikat = GetData(caller.Name, 2)
            cursorPos = caller.Location
            DetailsForm.Show()
            Console.WriteLine("In labelClick calling " + caller.Name)
        Catch ex As Exception
            MsgBox("An unexpected technical error occured [LabelClick]...\n\n" + ex.ToString)
        End Try

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load    'This functions check whether the resolution is correct or not and displays a warning accordingly
        Me.Location = New Point(0, 0)
        If Screen.PrimaryScreen.Bounds.Width <> REC_WIDTH Or Screen.PrimaryScreen.Bounds.Height <> REC_HEIGHT Then
            warningCode = 1
            ToolStripStatusLabel1.Text = SCREEN_WARNING
            MsgBox(SCREEN_WARNING)
        End If
    End Sub

    ' shows the help message
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim t As String = "Hover over any item on the Map to see a thumbnail. The name of place is displayed on the status bar."
        t += vbNewLine + vbNewLine + "Click on any item/thumbnail to view more information about that particular location"
        t += vbNewLine + vbNewLine + "For more information, check the User Manual"
        MsgBox(t, , "Help")
    End Sub
    ' shows About 
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim t As String = "IITG Campus Explorer"
        t += vbNewLine + vbNewLine + "This application was developed as part of Assignment 1 of Software Engineering Lab"
        t += vbNewLine + vbNewLine + "Credits:"
        t += vbNewLine + "Duddu Sai Meher Karthik" + vbNewLine + "Jainam Shah" + vbNewLine + "Ayush Mananiya" + vbNewLine + "Saikat Biswas" + vbNewLine + "Rahul"
        MsgBox(t, , "About this Application")
    End Sub

    'Function to handle focus being regained by the form -> activates all the hover events stopped by deactivate event
    Private Sub DetailMap_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Text = "Campus Explorer"
        isDeactivated = False
        Label2.Text = ""
        Label2.ForeColor = Color.Black
        If Not IsNothing(curLabelHover) Then
            label_MouseLeave(curLabelHover, e)
        End If
    End Sub

    'Function to handle focus being lost by the form -> freezes all the hover events so as to avoid confusing the user
    Private Sub DetailMap_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Text = "Campus Explorer: Out Of Focus"
        isDeactivated = True
        Label2.ForeColor = Color.Red
        Label2.Text = "Form currently" + vbNewLine + " out of focus. " + vbNewLine + "Click back here to resume."
    End Sub

    'Function to handle first-time usage of the program
    Private Sub DetailMap_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If MainForm.mapViewClickCount = 1 Then
            Dim t As String = "When in Map View, hover over any item to display thumbnail of that location"
            t += vbNewLine + vbNewLine + "Click on any thumbnail to display information about that location in the Description window. Moving focus out of description window closes it"
            t += vbNewLine + vbNewLine + "The Map View form will be frozen whenever focus is lost. To regain focus, click on the form again"
            MsgBox(t, MsgBoxStyle.Information, "First Time: Map View")
        End If
    End Sub

    'Function to handle Help button
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As String = "When in Map View, hover over any item to display thumbnail of that location"
        t += vbNewLine + vbNewLine + "Click on any thumbnail to display information about that location in the Description window. Moving focus out of description window closes it"
        t += vbNewLine + vbNewLine + "The Map View form will be frozen whenever focus is lost. To regain focus, click on the form again"
        MsgBox(t, MsgBoxStyle.Information, "Help: Map View")
    End Sub
End Class
