CREATE DATABASE QuanLyLuyenToan;
GO

USE QuanLyLuyenToan;
GO

-- Bảng Admin
CREATE TABLE admin (
    admin_id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(50) NOT NULL,
    password NVARCHAR(255) NOT NULL,
    role NVARCHAR(50),
    created_at DATETIME DEFAULT GETDATE()
);
drop table admin

-- Bảng Users
CREATE TABLE users (
    user_id NVARCHAR(50) NOT NULL PRIMARY KEY, -- Người dùng tự nhập ID, không tự động sinh
    username NVARCHAR(50) NOT NULL,
    email NVARCHAR(100),
    password NVARCHAR(255) NOT NULL,
    player_name NVARCHAR(50), -- Tên người chơi
    created_at DATETIME DEFAULT GETDATE()
);
drop table users;
select* from users

-- Bảng Questions
CREATE TABLE Questions (
    QuestionId INT PRIMARY KEY IDENTITY(1,1),
    QuestionText NVARCHAR(255) NOT NULL, -- Nội dung câu hỏi
    CorrectAnswer NVARCHAR(50) NOT NULL, -- Đáp án đúng
    Option1 NVARCHAR(50),                -- Lựa chọn 1
    Option2 NVARCHAR(50),                -- Lựa chọn 2
    Option3 NVARCHAR(50),                -- Lựa chọn 3
    DifficultyLevel INT,                 -- Độ khó: 1 (Dễ), 2 (Trung bình), 3 (Khó)
    QuestionType NVARCHAR(50)            -- Loại câu hỏi (Cộng, Trừ, Nhân, Chia)
);


-- Bảng Results
CREATE TABLE GameResults (
    result_id INT PRIMARY KEY IDENTITY(1,1),
    user_id NVARCHAR(50) FOREIGN KEY REFERENCES users(user_id),
    score INT NOT NULL,
    total_questions INT NOT NULL,
    correct_answers INT NOT NULL,
    incorrect_answers INT NOT NULL,
    SelectedAnswers NVARCHAR(MAX), -- Lưu đáp án chọn của người chơi
    played_at DATETIME DEFAULT GETDATE()
);


select* from GameResults
-- Bảng Leaderboard
CREATE TABLE leaderboard (
    leaderboard_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT FOREIGN KEY REFERENCES users(user_id),
    score INT NOT NULL,
    rank INT,
    updated_at DATETIME DEFAULT GETDATE()
);

-- Bảng Game Settings
CREATE TABLE game_settings (
    setting_id INT PRIMARY KEY IDENTITY(1,1),
    setting_name NVARCHAR(100) NOT NULL,
    value NVARCHAR(100) NOT NULL,
    description NVARCHAR(255)
);
drop table Questions

INSERT INTO Questions (QuestionText, CorrectAnswer, Option1, Option2, Option3, DifficultyLevel, QuestionType)
VALUES
('1 + 1 = ?', '2', '3', '4', '5', 1, 'Addition'),
('2 + 2 = ?', '4', '5', '6', '3', 1, 'Addition'),
('3 + 1 = ?', '4', '5', '6', '2', 1, 'Addition'),
('4 + 2 = ?', '6', '7', '5', '8', 1, 'Addition'),
('5 + 3 = ?', '8', '7', '9', '10', 1, 'Addition'),
('6 - 1 = ?', '5', '4', '6', '3', 1, 'Subtraction'),
('7 - 3 = ?', '4', '5', '6', '2', 1, 'Subtraction'),
('8 - 2 = ?', '6', '5', '4', '7', 1, 'Subtraction'),
('9 - 4 = ?', '5', '3', '2', '6', 1, 'Subtraction'),
('10 - 5 = ?', '5', '6', '4', '7', 1, 'Subtraction'),
('2 × 1 = ?', '2', '3', '4', '5', 1, 'Multiplication'),
('3 × 2 = ?', '6', '5', '4', '7', 1, 'Multiplication'),
('4 × 1 = ?', '4', '3', '2', '5', 1, 'Multiplication'),
('5 × 2 = ?', '10', '9', '8', '11', 1, 'Multiplication'),
('6 ÷ 2 = ?', '3', '2', '4', '1', 1, 'Division'),
('8 ÷ 4 = ?', '2', '3', '4', '5', 1, 'Division'),
('9 ÷ 3 = ?', '3', '4', '5', '2', 1, 'Division'),
('10 ÷ 5 = ?', '2', '1', '3', '4', 1, 'Division'),
('2 + 3 = ?', '5', '4', '6', '7', 1, 'Addition'),
('4 + 1 = ?', '5', '6', '3', '4', 1, 'Addition'),
('5 + 2 = ?', '7', '8', '9', '6', 1, 'Addition'),
('6 + 3 = ?', '9', '8', '7', '10', 1, 'Addition'),
('7 + 2 = ?', '9', '10', '8', '6', 1, 'Addition'),
('8 - 3 = ?', '5', '6', '4', '7', 1, 'Subtraction'),
('9 - 2 = ?', '7', '8', '6', '9', 1, 'Subtraction'),
('10 - 6 = ?', '4', '5', '3', '6', 1, 'Subtraction'),
('1 × 5 = ?', '5', '4', '6', '7', 1, 'Multiplication'),
('2 × 4 = ?', '8', '9', '7', '6', 1, 'Multiplication'),
('3 × 3 = ?', '9', '8', '7', '10', 1, 'Multiplication'),
('4 × 2 = ?', '8', '6', '5', '7', 1, 'Multiplication'),
('5 ÷ 1 = ?', '5', '6', '4', '7', 1, 'Division'),
('6 ÷ 3 = ?', '2', '3', '4', '1', 1, 'Division'),
('7 ÷ 1 = ?', '7', '6', '5', '8', 1, 'Division'),
('8 ÷ 2 = ?', '4', '3', '2', '5', 1, 'Division'),
('9 ÷ 9 = ?', '1', '2', '3', '4', 1, 'Division'),
('10 ÷ 2 = ?', '5', '4', '6', '7', 1, 'Division'),
('2 + 4 = ?', '6', '7', '5', '8', 1, 'Addition'),
('3 + 5 = ?', '8', '7', '6', '9', 1, 'Addition'),
('4 + 6 = ?', '10', '9', '8', '11', 1, 'Addition'),
('5 + 1 = ?', '6', '5', '7', '8', 1, 'Addition'),
('6 - 2 = ?', '4', '3', '5', '2', 1, 'Subtraction'),
('7 - 5 = ?', '2', '3', '1', '4', 1, 'Subtraction'),
('8 - 4 = ?', '4', '3', '5', '2', 1, 'Subtraction'),
('9 - 7 = ?', '2', '3', '1', '4', 1, 'Subtraction'),
('10 - 8 = ?', '2', '1', '3', '4', 1, 'Subtraction'),
('1 × 4 = ?', '4', '5', '3', '6', 1, 'Multiplication'),
('2 × 5 = ?', '10', '9', '11', '8', 1, 'Multiplication'),
('3 × 4 = ?', '12', '11', '13', '10', 1, 'Multiplication'),
('4 ÷ 2 = ?', '2', '3', '1', '4', 1, 'Division');

ALTER TABLE users DROP CONSTRAINT DF_users_user_id; -- Thay tên DF_users_user_id bằng tên thực tế
