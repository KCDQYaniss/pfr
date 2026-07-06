lucide.createIcons();

        // ---- Mobile Menu ----
        const menuToggle = document.getElementById('menuToggle');
        const menuClose = document.getElementById('menuClose');
        const mobileMenu = document.getElementById('mobileMenu');
        const mobileLinks = document.querySelectorAll('.mobile-link');

        menuToggle.addEventListener('click', () => mobileMenu.classList.add('active'));
        menuClose.addEventListener('click', () => mobileMenu.classList.remove('active'));
        mobileLinks.forEach(link => link.addEventListener('click', () => mobileMenu.classList.remove('active')));

        // ---- Scroll Reveal ----
        const observerOptions = { threshold: 0.1, rootMargin: '0px 0px -50px 0px' };
        const observer = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    entry.target.classList.add('revealed');
                    observer.unobserve(entry.target);
                }
            });
        }, observerOptions);

        document.querySelectorAll('.scroll-reveal').forEach(el => observer.observe(el));

        // ---- Counter Animation ----
        const counterObserver = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    const el = entry.target;
                    const target = parseInt(el.dataset.target);
                    let current = 0;
                    const increment = target / 60;
                    const timer = setInterval(() => {
                        current += increment;
                        if (current >= target) {
                            current = target;
                            clearInterval(timer);
                        }
                        if (el.dataset.target === '98') {
                            el.textContent = Math.round(current) + '%';
                        } else if (el.dataset.target === '100') {
                            el.textContent = Math.round(current) + '%';
                        } else {
                            el.textContent = Math.round(current) + '+';
                        }
                    }, 25);
                    counterObserver.unobserve(el);
                }
            });
        }, { threshold: 0.5 });

        document.querySelectorAll('.counter-value').forEach(el => counterObserver.observe(el));

        // ---- Gallery Filter ----
        const filterBtns = document.querySelectorAll('.filter-btn');
        const galleryItems = document.querySelectorAll('.gallery-item');

        filterBtns.forEach(btn => {
            btn.addEventListener('click', () => {
                filterBtns.forEach(b => {
                    b.classList.remove('active', 'bg-white/5', 'text-white');
                    b.classList.add('text-neutral-500');
                });
                btn.classList.add('active', 'bg-white/5', 'text-white');
                btn.classList.remove('text-neutral-500');

                const filter = btn.dataset.filter;

                galleryItems.forEach(item => {
                    if (filter === 'all' || item.dataset.category === filter) {
                        item.style.display = 'block';
                        item.style.opacity = '0';
                        item.style.transform = 'translateY(20px)';
                        setTimeout(() => {
                            item.style.transition = 'all 0.5s ease';
                            item.style.opacity = '1';
                            item.style.transform = 'translateY(0)';
                        }, 50);
                    } else {
                        item.style.transition = 'all 0.3s ease';
                        item.style.opacity = '0';
                        item.style.transform = 'translateY(20px)';
                        setTimeout(() => { item.style.display = 'none'; }, 300);
                    }
                });
            });
        });

        // ---- Lightbox ----
        const lightbox = document.getElementById('lightbox');
        const lightboxImg = document.getElementById('lightboxImg');
        const lightboxTitle = document.getElementById('lightboxTitle');
        const lightboxDesc = document.getElementById('lightboxDesc');

        function openLightbox(el) {
            const img = el.querySelector('img');
            const title = el.querySelector('h4');
            const desc = el.querySelector('p');
            lightboxImg.src = img.src.replace('/800/600', '/1400/1050');
            lightboxTitle.textContent = title ? title.textContent : '';
            lightboxDesc.textContent = desc ? desc.textContent : '';
            lightbox.classList.add('active');
            document.body.style.overflow = 'hidden';
        }

        function closeLightbox(e) {
            if (e.target === lightbox || e.currentTarget.tagName === 'BUTTON') {
                lightbox.classList.remove('active');
                document.body.style.overflow = '';
            }
        }

        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape' && lightbox.classList.contains('active')) {
                lightbox.classList.remove('active');
                document.body.style.overflow = '';
            }
        });

        // ---- Contact Form ----
        const contactForm = document.getElementById('contactForm');
        const toast = document.getElementById('toast');

        contactForm.addEventListener('submit', (e) => {
            e.preventDefault();

            const inputs = contactForm.querySelectorAll('[required]');
            let valid = true;
            inputs.forEach(input => {
                if (!input.value.trim()) {
                    valid = false;
                    input.style.borderColor = 'rgba(239,68,68,0.5)';
                    setTimeout(() => { input.style.borderColor = ''; }, 2000);
                }
            });

            if (!valid) return;

            const submitBtn = contactForm.querySelector('button[type="submit"]');
            const originalContent = submitBtn.innerHTML;
            submitBtn.innerHTML = '<svg class="animate-spin w-4 h-4" viewBox="0 0 24 24"><circle cx="12" cy="12" r="10" stroke="currentColor" stroke-width="3" fill="none" opacity="0.3"/><path d="M12 2a10 10 0 0 1 10 10" stroke="currentColor" stroke-width="3" fill="none" stroke-linecap="round"/></svg> Envoi en cours...';
            submitBtn.disabled = true;

            setTimeout(() => {
                toast.classList.add('show');
                setTimeout(() => toast.classList.remove('show'), 4000);

                contactForm.reset();
                submitBtn.innerHTML = originalContent;
                submitBtn.disabled = false;

                lucide.createIcons();
            }, 1500);
        });

        // ---- Navbar background on scroll ----
        const nav = document.querySelector('nav > div > div');
        window.addEventListener('scroll', () => {
            if (window.scrollY > 100) {
                nav.style.background = 'rgba(0,0,0,0.85)';
                nav.style.borderColor = 'rgba(255,255,255,0.08)';
            } else {
                nav.style.background = 'rgba(0,0,0,0.6)';
                nav.style.borderColor = 'rgba(255,255,255,0.05)';
            }
        });