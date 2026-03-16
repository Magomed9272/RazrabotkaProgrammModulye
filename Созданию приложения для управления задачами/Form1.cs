using System;
using System.Windows.Forms;
using Созданию_приложения_для_управления_задачами;

public class TaskForm : Form
{
    private TaskManager taskManager = new TaskManager();

    // Элементы управления
    private ListBox taskListBox;
    private TextBox titleTextBox;
    private TextBox descriptionTextBox;
    private Button addButton;
    private Button removeButton;
    private Button completeButton; // для дополнительного задания
    private Label titleLabel;
    private Label descriptionLabel;

    public TaskForm()
    {
        InitializeComponents();
        UpdateTaskList();
    }

    private void InitializeComponents()
    {
        // Настройка формы
        this.Text = "Управление задачами";
        this.Size = new System.Drawing.Size(500, 400);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Создание элементов
        titleLabel = new Label { Text = "Заголовок:", Location = new System.Drawing.Point(12, 15), Size = new System.Drawing.Size(70, 20) };
        titleTextBox = new TextBox { Location = new System.Drawing.Point(90, 12), Size = new System.Drawing.Size(380, 20) };

        descriptionLabel = new Label { Text = "Описание:", Location = new System.Drawing.Point(12, 45), Size = new System.Drawing.Size(70, 20) };
        descriptionTextBox = new TextBox { Location = new System.Drawing.Point(90, 42), Size = new System.Drawing.Size(380, 20) };

        addButton = new Button { Text = "Добавить задачу", Location = new System.Drawing.Point(12, 80), Size = new System.Drawing.Size(120, 30) };
        removeButton = new Button { Text = "Удалить", Location = new System.Drawing.Point(140, 80), Size = new System.Drawing.Size(100, 30) };
        completeButton = new Button { Text = "Выполнено", Location = new System.Drawing.Point(250, 80), Size = new System.Drawing.Size(100, 30) };

        taskListBox = new ListBox { Location = new System.Drawing.Point(12, 120), Size = new System.Drawing.Size(460, 220) };

        // Добавляем обработчики событий
        addButton.Click += AddButton_Click;
        removeButton.Click += RemoveButton_Click;
        completeButton.Click += CompleteButton_Click;

        // Добавляем контролы на форму
        this.Controls.AddRange(new Control[] {
            titleLabel, titleTextBox,
            descriptionLabel, descriptionTextBox,
            addButton, removeButton, completeButton,
            taskListBox
        });
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(titleTextBox.Text))
        {
            MessageBox.Show("Введите заголовок задачи!");
            return;
        }

        var task = new Task
        {
            Title = titleTextBox.Text,
            Description = descriptionTextBox.Text,
            IsCompleted = false
        };
        taskManager.AddTask(task);
        UpdateTaskList();

        // Очистка полей ввода
        titleTextBox.Clear();
        descriptionTextBox.Clear();
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
        if (taskListBox.SelectedItem is Task selectedTask)
        {
            taskManager.RemoveTask(selectedTask.Id);
            UpdateTaskList();
        }
        else
        {
            MessageBox.Show("Выберите задачу для удаления!");
        }
    }

    private void CompleteButton_Click(object sender, EventArgs e)
    {
        if (taskListBox.SelectedItem is Task selectedTask)
        {
            selectedTask.IsCompleted = !selectedTask.IsCompleted; // переключаем статус
            UpdateTaskList(); // обновляем отображение
        }
        else
        {
            MessageBox.Show("Выберите задачу для отметки!");
        }
    }

    private void UpdateTaskList()
    {
        taskListBox.Items.Clear();
        foreach (var task in taskManager.GetTasks())
        {
            taskListBox.Items.Add(task); // Добавляем сам объект Task, отображаться будет через ToString()
        }
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // TaskForm
            // 
            this.ClientSize = new System.Drawing.Size(780, 449);
            this.Name = "TaskForm";
            this.ResumeLayout(false);

    }
}