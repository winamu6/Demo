# ДЕМО ЭКЗ ТУТОР

Создаем проект "Приложение WPF (.NET Framework)

## БД

1. Создаем в корневой папке проекта папку **/DbConnect**.
2. В ней создаем элемент **"Модель ADO.NET EDM"**(ПКМ по папке DbConnection, потом нажимаем **"Добавить"**, потом нажимаем **"Создать элемент..."**, там в поиске ищем **"ADO.NET"**, в появившемся окне вводим название модели(у меня это **Model1.edmx**)), нажимаем далее. Откроется окно **"Мастер моделей EDM"**.
3. В окне **"Мастер моделей EDM"** выбираем "Конструктор EF из базы данных" потом жмем далее.
4. В окне **"Мастер моделей EDM"** нажимаем "Создать соединение". Откроется окно "Свойство подключения", заполним его. В качестве "Источника данных" указываем "Microsoft SQL Server (SqlClient)", вручную вводим имя сервера(можно скопировать при входе в SQL Server Management Studio), в "Проверка подлиности" выбираем "Проверка подлиности Sql Server", так же вводим **"Имя пользователя"** и **"Пароль"**(так же можно узнать при входе в SQL Server Management Studio), **ОБЯЗАТЕЛЬНО СТАВИМ ГАЛОЧКУ НА СЕРТИФИКАТ СЕРВЕРА**. Закрываем окно **"Свойства подключения"**, в окне **"Мастер моделей EDM"** ставим галочку на **"Сохранить параметры соединение в App.Config как:"**, **в строчке ниже вводим название свойства и запоминаем его**, жмем далее.
5. В окне **"Мастер моделей EDM"** выбираем **EntityFramework 5.0**, жмем далее.
6. В окне **"Мастер моделей EDM"** ставим галочку на "Таблицы", жмем готово, ждем когда модель создасться.
7. В папке **/DbConnect** создаем пустой **Класс**(ПКМ по папке DbConnection, потом нажимаем **"Добавить"**, там жмем "Класс", в открывшемся окне вводим "ConnectionString.cs"), открываем класс и вводим туда:
```
public class ConnectionString
{
	public static DemoEntities DemoEntities = new DemoEntities();
}
```
Вместо DemoEntities вводим **параметры соединения** из **4 пункта**(если забыли, захидим в **App.config** и ищем строку:
```
<connectionStrings>
	<add name="DemoEntities" connectionString="metadata=res://*/DbConnection.Model1.csdl|res://*/DbConnection.Model1.ssdl|res://*/DbConnection.Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-67UPOEU;initial catalog=Demo;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>
```
и вводим значение name="DemoEntities" вместо DemoEntities)

### ПОДКЛЮЧЕНИЕ БД ГОТОВО👍👍👍

