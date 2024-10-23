document.getElementById('forgotPasswordForm').addEventListener('submit', function (e) {
    e.preventDefault();
    const email = document.getElementById('email').value;

    if (email) {
        console.log('Password reset requested for:', email);
        alert('Nếu email tồn tại, một liên kết đặt lại mật khẩu sẽ được gửi.');
    } else {
        alert('Vui lòng nhập email hợp lệ!');
    }
});
