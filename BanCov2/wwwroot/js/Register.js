document.getElementById('registerForm').addEventListener('submit', function (e) {
    e.preventDefault();

    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;
    const confirmPassword = document.getElementById('confirmPassword').value;

    // Basic validation
    if (password !== confirmPassword) {
        alert('Mật khẩu xác nhận không khớp!');
        return;
    }

    if (email && password) {
        console.log('Đăng ký với:', email, password);
        alert('Đăng ký thành công!');
    } else {
        alert('Vui lòng nhập đầy đủ thông tin!');
    }
});

// Thêm hiệu ứng parallax cho form đăng ký
document.addEventListener('mousemove', function (e) {
    const container = document.querySelector('.container');
    const xAxis = (window.innerWidth / 2 - e.pageX) / 25;
    const yAxis = (window.innerHeight / 2 - e.pageY) / 25;
    container.style.transform = `rotateY(${xAxis}deg) rotateX(${yAxis}deg)`;
});
