document.getElementById('loginForm').addEventListener('submit', function (e) {
    e.preventDefault();
    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;

    console.log('Đăng nhập với:', email, password);
    alert('Đăng nhập thành công!');
});

// Thêm hiệu ứng parallax
document.addEventListener('mousemove', function (e) {
    const container = document.querySelector('.container');
    const xAxis = (window.innerWidth / 2 - e.pageX) / 25;
    const yAxis = (window.innerHeight / 2 - e.pageY) / 25;
    container.style.transform = `rotateY(${xAxis}deg) rotateX(${yAxis}deg)`;
});