using System.Windows.Forms;

namespace Iskra.App
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileLoginAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileCloseSession = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miLists = new System.Windows.Forms.ToolStripMenuItem();
            this.miListsClients = new System.Windows.Forms.ToolStripMenuItem();
            this.miListsSubscription = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.miListsCoaches = new System.Windows.Forms.ToolStripMenuItem();
            this.miListsUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.miListsDirectionsTraining = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.miListsDiscounts = new System.Windows.Forms.ToolStripMenuItem();
            this.miCash = new System.Windows.Forms.ToolStripMenuItem();
            this.miBar = new System.Windows.Forms.ToolStripMenuItem();
            this.miBarProductСatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.miBarVendors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.miBarReceipts = new System.Windows.Forms.ToolStripMenuItem();
            this.miReports = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pTabs = new System.Windows.Forms.Panel();
            this.pCommandsBorder = new System.Windows.Forms.Panel();
            this.btShowBarSale = new System.Windows.Forms.Button();
            this.btShowSubscriptionSales = new System.Windows.Forms.Button();
            this.btShowVisits = new System.Windows.Forms.Button();
            this.pCommands = new System.Windows.Forms.Panel();
            this.btRemove = new System.Windows.Forms.Button();
            this.btNewVisitor = new System.Windows.Forms.Button();
            this.btSellFromBar = new System.Windows.Forms.Button();
            this.btSellSubscription = new System.Windows.Forms.Button();
            this.lEndingSubscriptions = new System.Windows.Forms.Label();
            this.lNumberOfBirthdays = new System.Windows.Forms.Label();
            this.lСurrentUser = new System.Windows.Forms.Label();
            this.lСurrentUserName = new System.Windows.Forms.Label();
            this.lSessionStatus = new System.Windows.Forms.Label();
            this.lСash = new System.Windows.Forms.Label();
            this.lTerminal = new System.Windows.Forms.Label();
            this.gbDailyBalance = new System.Windows.Forms.GroupBox();
            this.lCashBalanc = new System.Windows.Forms.Label();
            this.lTerminalBalanc = new System.Windows.Forms.Label();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.pLableBorder = new System.Windows.Forms.Panel();
            this.lIskra = new System.Windows.Forms.Label();
            this.btShow = new System.Windows.Forms.Button();
            this.lTo = new System.Windows.Forms.Label();
            this.lFrom = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.pDateFilter = new System.Windows.Forms.Panel();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.pMessageBorder = new System.Windows.Forms.Panel();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bsVisits = new System.Windows.Forms.BindingSource(this.components);
            this.bsTicketSale = new System.Windows.Forms.BindingSource(this.components);
            this.bsProductSale = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            this.pTabs.SuspendLayout();
            this.pCommands.SuspendLayout();
            this.gbDailyBalance.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.pDateFilter.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTicketSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductSale)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miLists,
            this.miCash,
            this.miBar,
            this.miReports,
            this.miSettings,
            this.miHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileLoginAs,
            this.miFileCloseSession,
            this.toolStripSeparator1,
            this.miFileChangePassword,
            this.miFileUpdate,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.miFileExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // miFileLoginAs
            // 
            this.miFileLoginAs.Name = "miFileLoginAs";
            this.miFileLoginAs.Size = new System.Drawing.Size(180, 22);
            this.miFileLoginAs.Text = "Войти как...";
            this.miFileLoginAs.Click += new System.EventHandler(this.MiFileLoginAs_Click);
            // 
            // miFileChangePassword
            // 
            this.miFileChangePassword.Name = "miFileChangePassword";
            this.miFileChangePassword.Size = new System.Drawing.Size(180, 22);
            this.miFileChangePassword.Text = "Изменить пароль...";
            this.miFileChangePassword.Click += new System.EventHandler(this.MiFileChangePassword_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // miFileUpdate
            // 
            this.miFileUpdate.Name = "miFileUpdate";
            this.miFileUpdate.Size = new System.Drawing.Size(180, 22);
            this.miFileUpdate.Text = "Обновить";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // miFileCloseSession
            // 
            this.miFileCloseSession.Name = "miFileCloseSession";
            this.miFileCloseSession.Size = new System.Drawing.Size(180, 22);
            this.miFileCloseSession.Text = "Закрыть смену";
            this.miFileCloseSession.Click += new System.EventHandler(this.miFileCloseSession_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // miFileExit
            // 
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(180, 22);
            this.miFileExit.Text = "Выход";
            // 
            // miLists
            // 
            this.miLists.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miListsClients,
            this.miListsSubscription,
            this.toolStripSeparator5,
            this.miListsCoaches,
            this.miListsUsers,
            this.miListsDirectionsTraining,
            this.toolStripSeparator6,
            this.miListsDiscounts});
            this.miLists.Enabled = false;
            this.miLists.Name = "miLists";
            this.miLists.Size = new System.Drawing.Size(60, 20);
            this.miLists.Text = "Списки";
            // 
            // miListsClients
            // 
            this.miListsClients.Name = "miListsClients";
            this.miListsClients.Size = new System.Drawing.Size(203, 22);
            this.miListsClients.Text = "Клиенты...";
            this.miListsClients.Click += new System.EventHandler(this.MiListsClients_Click);
            // 
            // miListsSubscription
            // 
            this.miListsSubscription.Name = "miListsSubscription";
            this.miListsSubscription.Size = new System.Drawing.Size(203, 22);
            this.miListsSubscription.Text = "Абонементы...";
            this.miListsSubscription.Click += new System.EventHandler(this.MiListsSubscription_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(200, 6);
            // 
            // miListsCoaches
            // 
            this.miListsCoaches.Name = "miListsCoaches";
            this.miListsCoaches.Size = new System.Drawing.Size(203, 22);
            this.miListsCoaches.Text = "Тренеры...";
            this.miListsCoaches.Click += new System.EventHandler(this.MiListsCoaches_Click);
            // 
            // miListsUsers
            // 
            this.miListsUsers.Name = "miListsUsers";
            this.miListsUsers.Size = new System.Drawing.Size(203, 22);
            this.miListsUsers.Text = "Пользователи...";
            this.miListsUsers.Click += new System.EventHandler(this.MiListsUsers_Click);
            // 
            // miListsDirectionsTraining
            // 
            this.miListsDirectionsTraining.Name = "miListsDirectionsTraining";
            this.miListsDirectionsTraining.Size = new System.Drawing.Size(203, 22);
            this.miListsDirectionsTraining.Text = "Направления занятий...";
            this.miListsDirectionsTraining.Click += new System.EventHandler(this.MiListsDirectionsTraining_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(200, 6);
            // 
            // miListsDiscounts
            // 
            this.miListsDiscounts.Name = "miListsDiscounts";
            this.miListsDiscounts.Size = new System.Drawing.Size(203, 22);
            this.miListsDiscounts.Text = "Скидки...";
            this.miListsDiscounts.Click += new System.EventHandler(this.MiListsDiscounts_Click);
            // 
            // miCash
            // 
            this.miCash.Enabled = false;
            this.miCash.Name = "miCash";
            this.miCash.Size = new System.Drawing.Size(50, 20);
            this.miCash.Text = "Касса";
            // 
            // miBar
            // 
            this.miBar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBarProductСatalog,
            this.miBarVendors,
            this.toolStripSeparator7,
            this.miBarReceipts});
            this.miBar.Enabled = false;
            this.miBar.Name = "miBar";
            this.miBar.Size = new System.Drawing.Size(39, 20);
            this.miBar.Text = "Бар";
            // 
            // miBarProductСatalog
            // 
            this.miBarProductСatalog.Name = "miBarProductСatalog";
            this.miBarProductСatalog.Size = new System.Drawing.Size(173, 22);
            this.miBarProductСatalog.Text = "Каталог товаров...";
            this.miBarProductСatalog.Click += new System.EventHandler(this.MiBarProductСatalog_Click);
            // 
            // miBarVendors
            // 
            this.miBarVendors.Name = "miBarVendors";
            this.miBarVendors.Size = new System.Drawing.Size(173, 22);
            this.miBarVendors.Text = "Поставщики...";
            this.miBarVendors.Click += new System.EventHandler(this.MiBarVendors_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(170, 6);
            // 
            // miBarReceipts
            // 
            this.miBarReceipts.Name = "miBarReceipts";
            this.miBarReceipts.Size = new System.Drawing.Size(173, 22);
            this.miBarReceipts.Text = "Поступления...";
            // 
            // miReports
            // 
            this.miReports.Enabled = false;
            this.miReports.Name = "miReports";
            this.miReports.Size = new System.Drawing.Size(60, 20);
            this.miReports.Text = "Отчеты";
            // 
            // miSettings
            // 
            this.miSettings.Enabled = false;
            this.miSettings.Name = "miSettings";
            this.miSettings.Size = new System.Drawing.Size(79, 20);
            this.miSettings.Text = "Настройки";
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(68, 20);
            this.miHelp.Text = "Помощь";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // pTabs
            // 
            this.pTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTabs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pTabs.Controls.Add(this.pCommandsBorder);
            this.pTabs.Controls.Add(this.btShowBarSale);
            this.pTabs.Controls.Add(this.btShowSubscriptionSales);
            this.pTabs.Controls.Add(this.btShowVisits);
            this.pTabs.Location = new System.Drawing.Point(0, 103);
            this.pTabs.Name = "pTabs";
            this.pTabs.Size = new System.Drawing.Size(784, 60);
            this.pTabs.TabIndex = 2;
            // 
            // pCommandsBorder
            // 
            this.pCommandsBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCommandsBorder.BackColor = System.Drawing.Color.NavajoWhite;
            this.pCommandsBorder.Location = new System.Drawing.Point(1, 53);
            this.pCommandsBorder.Name = "pCommandsBorder";
            this.pCommandsBorder.Size = new System.Drawing.Size(784, 4);
            this.pCommandsBorder.TabIndex = 4;
            // 
            // btShowBarSale
            // 
            this.btShowBarSale.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btShowBarSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowBarSale.Image = global::Iskra.App.Properties.Resources.bar;
            this.btShowBarSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btShowBarSale.Location = new System.Drawing.Point(523, 8);
            this.btShowBarSale.Name = "btShowBarSale";
            this.btShowBarSale.Size = new System.Drawing.Size(250, 38);
            this.btShowBarSale.TabIndex = 2;
            this.btShowBarSale.Text = "Отображать продажи из бара";
            this.btShowBarSale.UseVisualStyleBackColor = false;
            this.btShowBarSale.Click += new System.EventHandler(this.BtShowBarSale_Click);
            // 
            // btShowSubscriptionSales
            // 
            this.btShowSubscriptionSales.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btShowSubscriptionSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowSubscriptionSales.Image = global::Iskra.App.Properties.Resources.visit;
            this.btShowSubscriptionSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btShowSubscriptionSales.Location = new System.Drawing.Point(264, 8);
            this.btShowSubscriptionSales.Name = "btShowSubscriptionSales";
            this.btShowSubscriptionSales.Size = new System.Drawing.Size(250, 38);
            this.btShowSubscriptionSales.TabIndex = 1;
            this.btShowSubscriptionSales.Text = "Отображать продажи абонементов ";
            this.btShowSubscriptionSales.UseVisualStyleBackColor = false;
            this.btShowSubscriptionSales.Click += new System.EventHandler(this.BtShowSubscriptionSales_Click);
            // 
            // btShowVisits
            // 
            this.btShowVisits.BackColor = System.Drawing.Color.NavajoWhite;
            this.btShowVisits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowVisits.Image = global::Iskra.App.Properties.Resources.people;
            this.btShowVisits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btShowVisits.Location = new System.Drawing.Point(5, 8);
            this.btShowVisits.Name = "btShowVisits";
            this.btShowVisits.Size = new System.Drawing.Size(250, 38);
            this.btShowVisits.TabIndex = 0;
            this.btShowVisits.TabStop = false;
            this.btShowVisits.Text = "Отображать посещения";
            this.btShowVisits.UseVisualStyleBackColor = false;
            this.btShowVisits.Click += new System.EventHandler(this.BtShowVisits_Click);
            // 
            // pCommands
            // 
            this.pCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pCommands.Controls.Add(this.btRemove);
            this.pCommands.Controls.Add(this.btNewVisitor);
            this.pCommands.Controls.Add(this.btSellFromBar);
            this.pCommands.Controls.Add(this.btSellSubscription);
            this.pCommands.Enabled = false;
            this.pCommands.Location = new System.Drawing.Point(563, 169);
            this.pCommands.Name = "pCommands";
            this.pCommands.Size = new System.Drawing.Size(216, 163);
            this.pCommands.TabIndex = 4;
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemove.Image = global::Iskra.App.Properties.Resources.remove;
            this.btRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRemove.Location = new System.Drawing.Point(3, 121);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(210, 36);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Удалить...";
            this.btRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRemove.UseVisualStyleBackColor = false;
            // 
            // btNewVisitor
            // 
            this.btNewVisitor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btNewVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewVisitor.Image = global::Iskra.App.Properties.Resources.addVisitor;
            this.btNewVisitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNewVisitor.Location = new System.Drawing.Point(3, 3);
            this.btNewVisitor.Name = "btNewVisitor";
            this.btNewVisitor.Size = new System.Drawing.Size(210, 36);
            this.btNewVisitor.TabIndex = 0;
            this.btNewVisitor.Text = "Новый посетитель...";
            this.btNewVisitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNewVisitor.UseVisualStyleBackColor = false;
            this.btNewVisitor.Click += new System.EventHandler(this.btNewVisitor_Click);
            // 
            // btSellFromBar
            // 
            this.btSellFromBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSellFromBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSellFromBar.Image = global::Iskra.App.Properties.Resources.bar;
            this.btSellFromBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSellFromBar.Location = new System.Drawing.Point(3, 82);
            this.btSellFromBar.Name = "btSellFromBar";
            this.btSellFromBar.Size = new System.Drawing.Size(210, 36);
            this.btSellFromBar.TabIndex = 2;
            this.btSellFromBar.Text = "Продать из бара...";
            this.btSellFromBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSellFromBar.UseVisualStyleBackColor = false;
            // 
            // btSellSubscription
            // 
            this.btSellSubscription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSellSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSellSubscription.Image = global::Iskra.App.Properties.Resources.subscription;
            this.btSellSubscription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSellSubscription.Location = new System.Drawing.Point(3, 43);
            this.btSellSubscription.Name = "btSellSubscription";
            this.btSellSubscription.Size = new System.Drawing.Size(210, 36);
            this.btSellSubscription.TabIndex = 1;
            this.btSellSubscription.Text = "Продать абонемент...";
            this.btSellSubscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSellSubscription.UseVisualStyleBackColor = false;
            this.btSellSubscription.Click += new System.EventHandler(this.btSellSubscription_Click);
            // 
            // lEndingSubscriptions
            // 
            this.lEndingSubscriptions.AutoSize = true;
            this.lEndingSubscriptions.ForeColor = System.Drawing.Color.Red;
            this.lEndingSubscriptions.Location = new System.Drawing.Point(3, 7);
            this.lEndingSubscriptions.Name = "lEndingSubscriptions";
            this.lEndingSubscriptions.Size = new System.Drawing.Size(188, 13);
            this.lEndingSubscriptions.TabIndex = 7;
            this.lEndingSubscriptions.Text = "Заканчичвающиеся абонементы (9)";
            // 
            // lNumberOfBirthdays
            // 
            this.lNumberOfBirthdays.AutoSize = true;
            this.lNumberOfBirthdays.ForeColor = System.Drawing.Color.Red;
            this.lNumberOfBirthdays.Location = new System.Drawing.Point(3, 32);
            this.lNumberOfBirthdays.Name = "lNumberOfBirthdays";
            this.lNumberOfBirthdays.Size = new System.Drawing.Size(96, 13);
            this.lNumberOfBirthdays.TabIndex = 8;
            this.lNumberOfBirthdays.Text = "Дни рождения (2)";
            // 
            // lСurrentUser
            // 
            this.lСurrentUser.AutoSize = true;
            this.lСurrentUser.Location = new System.Drawing.Point(37, 62);
            this.lСurrentUser.Name = "lСurrentUser";
            this.lСurrentUser.Size = new System.Drawing.Size(129, 13);
            this.lСurrentUser.TabIndex = 9;
            this.lСurrentUser.Text = "Текущий пользователь:";
            // 
            // lСurrentUserName
            // 
            this.lСurrentUserName.AutoSize = true;
            this.lСurrentUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lСurrentUserName.Location = new System.Drawing.Point(42, 77);
            this.lСurrentUserName.Name = "lСurrentUserName";
            this.lСurrentUserName.Size = new System.Drawing.Size(119, 13);
            this.lСurrentUserName.TabIndex = 10;
            this.lСurrentUserName.Text = "Вход не выполнен!";
            // 
            // lSessionStatus
            // 
            this.lSessionStatus.AutoSize = true;
            this.lSessionStatus.ForeColor = System.Drawing.Color.Red;
            this.lSessionStatus.Location = new System.Drawing.Point(41, 106);
            this.lSessionStatus.Name = "lSessionStatus";
            this.lSessionStatus.Size = new System.Drawing.Size(119, 13);
            this.lSessionStatus.TabIndex = 11;
            this.lSessionStatus.Text = "СМЕНА НЕ ОТКРЫТА";
            // 
            // lСash
            // 
            this.lСash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lСash.AutoSize = true;
            this.lСash.Location = new System.Drawing.Point(24, 19);
            this.lСash.Name = "lСash";
            this.lСash.Size = new System.Drawing.Size(61, 13);
            this.lСash.TabIndex = 13;
            this.lСash.Text = "Наличные:";
            // 
            // lTerminal
            // 
            this.lTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTerminal.AutoSize = true;
            this.lTerminal.Location = new System.Drawing.Point(24, 40);
            this.lTerminal.Name = "lTerminal";
            this.lTerminal.Size = new System.Drawing.Size(61, 13);
            this.lTerminal.TabIndex = 15;
            this.lTerminal.Text = "Терминал:";
            // 
            // gbDailyBalance
            // 
            this.gbDailyBalance.Controls.Add(this.lCashBalanc);
            this.gbDailyBalance.Controls.Add(this.lСash);
            this.gbDailyBalance.Controls.Add(this.lTerminalBalanc);
            this.gbDailyBalance.Controls.Add(this.lTerminal);
            this.gbDailyBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDailyBalance.Location = new System.Drawing.Point(6, 131);
            this.gbDailyBalance.Name = "gbDailyBalance";
            this.gbDailyBalance.Size = new System.Drawing.Size(185, 67);
            this.gbDailyBalance.TabIndex = 17;
            this.gbDailyBalance.TabStop = false;
            this.gbDailyBalance.Text = "Средства";
            // 
            // lCashBalanc
            // 
            this.lCashBalanc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lCashBalanc.AutoSize = true;
            this.lCashBalanc.Location = new System.Drawing.Point(83, 19);
            this.lCashBalanc.Name = "lCashBalanc";
            this.lCashBalanc.Size = new System.Drawing.Size(0, 13);
            this.lCashBalanc.TabIndex = 13;
            // 
            // lTerminalBalanc
            // 
            this.lTerminalBalanc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTerminalBalanc.AutoSize = true;
            this.lTerminalBalanc.Location = new System.Drawing.Point(83, 40);
            this.lTerminalBalanc.Name = "lTerminalBalanc";
            this.lTerminalBalanc.Size = new System.Drawing.Size(0, 13);
            this.lTerminalBalanc.TabIndex = 15;
            // 
            // labelPanel
            // 
            this.labelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.pLableBorder);
            this.labelPanel.Controls.Add(this.lIskra);
            this.labelPanel.Location = new System.Drawing.Point(0, 24);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(1267, 80);
            this.labelPanel.TabIndex = 18;
            // 
            // pLableBorder
            // 
            this.pLableBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLableBorder.BackColor = System.Drawing.Color.NavajoWhite;
            this.pLableBorder.Location = new System.Drawing.Point(0, 74);
            this.pLableBorder.Name = "pLableBorder";
            this.pLableBorder.Size = new System.Drawing.Size(1267, 7);
            this.pLableBorder.TabIndex = 1;
            // 
            // lIskra
            // 
            this.lIskra.AutoSize = true;
            this.lIskra.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lIskra.ForeColor = System.Drawing.Color.Gray;
            this.lIskra.Location = new System.Drawing.Point(12, 22);
            this.lIskra.Name = "lIskra";
            this.lIskra.Size = new System.Drawing.Size(203, 26);
            this.lIskra.TabIndex = 0;
            this.lIskra.Text = "Скалодром Искра";
            // 
            // btShow
            // 
            this.btShow.BackColor = System.Drawing.SystemColors.Window;
            this.btShow.Location = new System.Drawing.Point(32, 51);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(142, 23);
            this.btShow.TabIndex = 6;
            this.btShow.Text = "Показать";
            this.btShow.UseVisualStyleBackColor = false;
            // 
            // lTo
            // 
            this.lTo.AutoSize = true;
            this.lTo.Location = new System.Drawing.Point(5, 35);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(24, 13);
            this.lTo.TabIndex = 5;
            this.lTo.Text = "По:";
            // 
            // lFrom
            // 
            this.lFrom.AutoSize = true;
            this.lFrom.Location = new System.Drawing.Point(12, 10);
            this.lFrom.Name = "lFrom";
            this.lFrom.Size = new System.Drawing.Size(17, 13);
            this.lFrom.TabIndex = 4;
            this.lFrom.Text = "С:";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd  MMM yyyy HH:mm";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(32, 29);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(142, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd  MMM yyyy HH:mm";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(32, 7);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(142, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // pDateFilter
            // 
            this.pDateFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pDateFilter.BackColor = System.Drawing.SystemColors.Info;
            this.pDateFilter.Controls.Add(this.lFrom);
            this.pDateFilter.Controls.Add(this.btShow);
            this.pDateFilter.Controls.Add(this.dtpFrom);
            this.pDateFilter.Controls.Add(this.lTo);
            this.pDateFilter.Controls.Add(this.dtpTo);
            this.pDateFilter.Location = new System.Drawing.Point(600, 24);
            this.pDateFilter.Name = "pDateFilter";
            this.pDateFilter.Size = new System.Drawing.Size(180, 74);
            this.pDateFilter.TabIndex = 7;
            // 
            // messagePanel
            // 
            this.messagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messagePanel.Controls.Add(this.pMessageBorder);
            this.messagePanel.Location = new System.Drawing.Point(0, 588);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(784, 20);
            this.messagePanel.TabIndex = 31;
            // 
            // pMessageBorder
            // 
            this.pMessageBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMessageBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pMessageBorder.Location = new System.Drawing.Point(0, 1);
            this.pMessageBorder.Name = "pMessageBorder";
            this.pMessageBorder.Size = new System.Drawing.Size(784, 2);
            this.pMessageBorder.TabIndex = 4;
            // 
            // StatusPanel
            // 
            this.StatusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusPanel.Controls.Add(this.lEndingSubscriptions);
            this.StatusPanel.Controls.Add(this.lNumberOfBirthdays);
            this.StatusPanel.Controls.Add(this.lСurrentUser);
            this.StatusPanel.Controls.Add(this.lСurrentUserName);
            this.StatusPanel.Controls.Add(this.lSessionStatus);
            this.StatusPanel.Controls.Add(this.gbDailyBalance);
            this.StatusPanel.Location = new System.Drawing.Point(563, 380);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(216, 208);
            this.StatusPanel.TabIndex = 33;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DataSource = this.bsVisits;
            this.dgv.Location = new System.Drawing.Point(4, 169);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(553, 409);
            this.dgv.TabIndex = 33;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 608);
            this.Controls.Add(this.pCommands);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.pDateFilter);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.pTabs);
            this.Controls.Add(this.menuStrip);
            this.Location = new System.Drawing.Point(563, 169);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 647);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Скалодром Искра";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pTabs.ResumeLayout(false);
            this.pCommands.ResumeLayout(false);
            this.gbDailyBalance.ResumeLayout(false);
            this.gbDailyBalance.PerformLayout();
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.pDateFilter.ResumeLayout(false);
            this.pDateFilter.PerformLayout();
            this.messagePanel.ResumeLayout(false);
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTicketSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pTabs;
        private System.Windows.Forms.Panel pCommandsBorder;
        private System.Windows.Forms.Button btShowBarSale;
        private System.Windows.Forms.Button btShowSubscriptionSales;
        private System.Windows.Forms.Button btShowVisits;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btSellFromBar;
        private System.Windows.Forms.Button btSellSubscription;
        private System.Windows.Forms.Button btNewVisitor;
        private System.Windows.Forms.Label lEndingSubscriptions;
        private System.Windows.Forms.Label lNumberOfBirthdays;
        private System.Windows.Forms.Label lСurrentUser;
        private System.Windows.Forms.Label lСash;
        private System.Windows.Forms.Label lTerminal;
        private System.Windows.Forms.GroupBox gbDailyBalance;
        private System.Windows.Forms.ToolStripMenuItem miFileLoginAs;
        private System.Windows.Forms.ToolStripMenuItem miFileChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miFileUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem miFileCloseSession;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem miListsClients;
        private System.Windows.Forms.ToolStripMenuItem miListsSubscription;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem miListsCoaches;
        private System.Windows.Forms.ToolStripMenuItem miListsUsers;
        private System.Windows.Forms.ToolStripMenuItem miListsDirectionsTraining;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem miListsDiscounts;
        private System.Windows.Forms.ToolStripMenuItem miBarProductСatalog;
        private System.Windows.Forms.ToolStripMenuItem miBarVendors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem miBarReceipts;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Label lIskra;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.Label lFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel pDateFilter;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel pMessageBorder;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Panel pLableBorder;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource bsVisits;
        private System.Windows.Forms.BindingSource bsTicketSale;
        private System.Windows.Forms.BindingSource bsProductSale;
        private Panel pCommands;
        public Label lSessionStatus;
        public ToolStripMenuItem miLists;
        public ToolStripMenuItem miCash;
        public ToolStripMenuItem miBar;
        public ToolStripMenuItem miReports;
        public ToolStripMenuItem miSettings;
        public Label lCashBalanc;
        public Label lTerminalBalanc;
        public Label lСurrentUserName;
    }
}

