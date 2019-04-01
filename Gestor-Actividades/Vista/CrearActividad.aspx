<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearActividad.aspx.cs" Inherits="Gestor_Actividades.Vista.CrearActividad" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Actividad</title>
    <link href="/CSS/StyleSheet1.css" rel="Stylesheet" type="text/css"/>
    <style type="text/css">
        .auto-style1 {
            height: 378px;
        }
        .auto-style2 {
            height: 747px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="menuOpciones"><br />
            <asp:Button ID="botonCrearAct" runat="server" Text="Crear Actividad" CssClass="botones" OnClick="botonCrearAct_Click"/><br />
            <asp:Button ID="botonVerAct" runat="server" Text="Ver Actividades" CssClass="botones" OnClick="botonVerAct_Click"/><br />
            <asp:Button ID="botonCrearStaff" runat="server" Text="Crear Staff" CssClass="botones" OnClick="botonCrearStaff_Click"/>
        </div>

        <div id="seccion" class="auto-style2"><br />
            <div id="titulo">
                <h1>Crear actividad</h1>
            </div>
            <br /><br /><br />
                <div id="form2" class="auto-style1">
                    Nombre de la actividad:<br />
                <asp:TextBox ID="txtBox_nombre" runat="server"></asp:TextBox><br />
                <label>Campus/Centro Académico&nbsp;                 &nbsp;<asp:D&nbsp;<asp:DropDownList ID="DropDownList_Campus" runat="server">
                    <asp:ListItem>Campus Cartago</asp:ListItem>
                    <asp:ListItem>Campus San Carlos</asp:ListItem>
                    <asp:ListItem>CA San José</asp:ListItem>
                    <asp:ListItem>CA Alajuela</asp:ListItem>
                    <asp:ListItem>CA Limón</asp:ListItem>
                </asp:DropDownList><br /><br />
                
                <br />
                Lugar:<asp:TextBox ID="txtBox_lugar" runat="server" Text="Lugar"></asp:TextBox><br />Fecha:<br />
                <asp:TextBox ID="txtBox_fecha" runat="server" Text="Fecha"></asp:TextBox><br /><br />
        Horario:<asp:TextBox ID="txtBox_horario" runat="server" Text="Horario"></asp:TextBox>
                <br />
                Cupo Reservado:<asp:CheckBox ID="CheckBox1" runat="server" />
                <br />
                <br />
                <label>Cantidad de cupos:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList_CantCupos" runat="server">
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                    <asp:ListItem>32</asp:ListItem>
                    <asp:ListItem>33</asp:ListItem>
                    <asp:ListItem>34</asp:ListItem>
                    <asp:ListItem>35</asp:ListItem>
                    <asp:ListItem>36</asp:ListItem>
                    <asp:ListItem>37</asp:ListItem>
                    <asp:ListItem>38</asp:ListItem>
                    <asp:ListItem>39</asp:ListItem>
                    <asp:ListItem>40</asp:ListItem>
                    <asp:ListItem>41</asp:ListItem>
                    <asp:ListItem>42</asp:ListItem>
                    <asp:ListItem>43</asp:ListItem>
                    <asp:ListItem>44</asp:ListItem>
                    <asp:ListItem>45</asp:ListItem>
                    <asp:ListItem>46</asp:ListItem>
                    <asp:ListItem>47</asp:ListItem>
                    <asp:ListItem>48</asp:ListItem>
                    <asp:ListItem>49</asp:ListItem>
                    <asp:ListItem>50</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <br /><br />
                <label>Encargadoscargados</label><br />
                <br /><br />
                <asp:FileUpload ID="FileUpload1" runat="server" /><br /><br />
                <asp:Button ID="botonRegistrar" runat="server" Text="Registrar" CssClass="botones" OnClick="botonRegistrar_Click" />
                </div>
            
        </div>
    </form>
</body>
</html>
